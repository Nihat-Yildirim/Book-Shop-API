using BookShopAPI.Application.DTOs.OtpAuthenticationDTOs;
using BookShopAPI.Application.Helpers.Hashing;
using BookShopAPI.Application.OtpAuthenticator;
using BookShopAPI.Application.Repositories.OtpAuthenticationRepositories;
using BookShopAPI.Application.Repositories.UserRepositories;
using BookShopAPI.Application.UnitOfWork;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Domain.Enums;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.OtpAuthenticationCommands.AddOtpAuthentication
{
    public class AddOtpAuthenticationCommandHandler : IRequestHandler<AddOtpAuthenticationCommandRequest, BaseDataResponse<OtpAuthenticationQrCodeUrlDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IOtpAuthenticator _otpAuthenticator;
        private readonly IUserReadRepository _userReadRepository;
        private readonly IOtpAuthenticationWriteRepository _authenticationWriteRepository;

        public AddOtpAuthenticationCommandHandler(IUnitOfWork unitOfWork, IOtpAuthenticator otpAuthenticator, IUserReadRepository userReadRepository, IOtpAuthenticationWriteRepository authenticationWriteRepository)
        {
            _unitOfWork = unitOfWork;
            _otpAuthenticator = otpAuthenticator;
            _userReadRepository = userReadRepository;
            _authenticationWriteRepository = authenticationWriteRepository;
        }

        public async Task<BaseDataResponse<OtpAuthenticationQrCodeUrlDto>> Handle(AddOtpAuthenticationCommandRequest request, CancellationToken cancellationToken)
        {
            var selectedUser = await _userReadRepository.GetSingleAsync(x => x.Email == request.Email && x.DeletedDate == null && x.AuthenticatorType == AuthenticatorType.None);
            if(selectedUser == null) 
                return new FailDataResponse<OtpAuthenticationQrCodeUrlDto>();

            bool isVerify = HashingHelper.VerifyPasswordHash(request.Password, selectedUser.PasswordHash, selectedUser.PasswordSalt);
            if(!isVerify)
                return new FailDataResponse<OtpAuthenticationQrCodeUrlDto>();

            byte[] secretKey = _otpAuthenticator.CreateSecretKey();

            OtpAuthentication otpAuthentication = new()
            {
                Id = selectedUser.Id,
                IsVerified = false,
                SecretKey = secretKey,
            };

            await _authenticationWriteRepository.AddAsync(otpAuthentication);
            await _unitOfWork.SaveChangesAsync();

            OtpAuthenticationQrCodeUrlDto result = new();
            var sharedKey = _otpAuthenticator.ConvertSecretKeyToString(secretKey);
            result.QrCodeUrl = _otpAuthenticator.GenerateQrCodeUri(sharedKey,"BookShop İkili Doğrulama Kodu",selectedUser);

            return new SuccessDataResponse<OtpAuthenticationQrCodeUrlDto>(result);
        }
    }
}