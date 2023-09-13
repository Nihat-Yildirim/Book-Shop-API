using BookShopAPI.Application.DTOs.OtpAuthenticationDTOs;
using BookShopAPI.Application.OtpAuthenticator;
using BookShopAPI.Application.Repositories.OtpAuthenticationRepositories;
using BookShopAPI.Application.Repositories.UserRepositories;
using BookShopAPI.Application.UnitOfWork;
using BookShopAPI.Domain.Enums;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookShopAPI.Application.CQRS.Commands.OtpAuthenticationCommands.SaveOtpAuthentication
{
    public class SaveOtpAuthenticationCommandHandler : IRequestHandler<SaveOtpAuthenticationCommandRequest, BaseDataResponse<OtpAuthenticationQrCodeUrlDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IOtpAuthenticator _otpAuthenticator;
        private readonly IUserReadRepository _userReadRepository;
        private readonly IOtpAuthenticationReadRepository _otpAuthenticationReadRepository;

        public SaveOtpAuthenticationCommandHandler(IUnitOfWork unitOfWork, IOtpAuthenticator otpAuthenticator, IUserReadRepository userReadRepository, IOtpAuthenticationReadRepository otpAuthenticationReadRepository)
        {
            _unitOfWork = unitOfWork;
            _otpAuthenticator = otpAuthenticator;
            _userReadRepository = userReadRepository;
            _otpAuthenticationReadRepository = otpAuthenticationReadRepository;
        }

        public async Task<BaseDataResponse<OtpAuthenticationQrCodeUrlDto>> Handle(SaveOtpAuthenticationCommandRequest request, CancellationToken cancellationToken)
        {
            var selectedUser = await _userReadRepository.GetSingleAsync(x => x.Email == request.Email && x.AuthenticatorType == AuthenticatorType.Otp && x.DeletedDate == null);
            if (selectedUser == null)
                return new FailDataResponse<OtpAuthenticationQrCodeUrlDto>();

            var selectedOtpAuthenticaiton = await _otpAuthenticationReadRepository.Table
                                                    .Include(x => x.OtpRecoveryCodes)
                                                    .SingleOrDefaultAsync(x => x.Id == selectedUser.Id && x.IsVerified == true);

            if(selectedOtpAuthenticaiton == null)
                return new FailDataResponse<OtpAuthenticationQrCodeUrlDto>();

            if(!selectedOtpAuthenticaiton.OtpRecoveryCodes.Select(x => x.Code).Contains(request.RecoveryCode))
                return new FailDataResponse<OtpAuthenticationQrCodeUrlDto>();

            byte[] secretKey = _otpAuthenticator.CreateSecretKey();
            selectedOtpAuthenticaiton.SecretKey = secretKey;
            await _unitOfWork.SaveChangesAsync();

            OtpAuthenticationQrCodeUrlDto urlDto = new();
            string sharedKey = _otpAuthenticator.ConvertSecretKeyToString(secretKey);
            urlDto.QrCodeUrl = _otpAuthenticator.GenerateQrCodeUri(sharedKey, "BookShop İkili Doğrulama Kodu", selectedUser);

            return new SuccessDataResponse<OtpAuthenticationQrCodeUrlDto>(urlDto);
        }
    }
}