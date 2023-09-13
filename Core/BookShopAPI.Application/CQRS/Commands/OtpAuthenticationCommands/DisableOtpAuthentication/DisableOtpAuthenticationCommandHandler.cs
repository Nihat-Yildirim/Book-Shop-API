using BookShopAPI.Application.OtpAuthenticator;
using BookShopAPI.Application.Repositories.OtpAuthenticationRepositories;
using BookShopAPI.Application.Repositories.UserRepositories;
using BookShopAPI.Application.UnitOfWork;
using BookShopAPI.Domain.Enums;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.OtpAuthenticationCommands.DisableOtpAuthentication
{
    public class DisableOtpAuthenticationCommandHandler : IRequestHandler<DisableOtpAuthenticationCommandRequest, BaseResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IOtpAuthenticator _otpAuthenticator;
        private readonly IUserReadRepository _userReadRepository;
        private readonly IOtpAuthenticationReadRepository _otpAuthenticationReadRepository;
        private readonly IOtpAuthenticationWriteRepository _otpAuthenticationWriteRepository;

        public DisableOtpAuthenticationCommandHandler(IUnitOfWork unitOfWork, IOtpAuthenticator otpAuthenticator, IUserReadRepository userReadRepository, IOtpAuthenticationReadRepository otpAuthenticationReadRepository, IOtpAuthenticationWriteRepository otpAuthenticationWriteRepository)
        {
            _unitOfWork = unitOfWork;
            _otpAuthenticator = otpAuthenticator;
            _userReadRepository = userReadRepository;
            _otpAuthenticationReadRepository = otpAuthenticationReadRepository;
            _otpAuthenticationWriteRepository = otpAuthenticationWriteRepository;
        }

        public async Task<BaseResponse> Handle(DisableOtpAuthenticationCommandRequest request, CancellationToken cancellationToken)
        {
            var selectedUser = await _userReadRepository.GetSingleAsync(x => x.Email == request.Email && x.DeletedDate == null && x.AuthenticatorType == AuthenticatorType.Otp);
            if (selectedUser == null)
                return new FailNoDataResponse();

            var selectedOtpAuthentication = await _otpAuthenticationReadRepository.GetByIdAsync(selectedUser.Id);
            if (selectedOtpAuthentication == null)
                return new FailNoDataResponse();

            bool isVerify = _otpAuthenticator.VerifyCode(selectedOtpAuthentication.SecretKey, request.ActivationCode);
            if (!isVerify)
                return new FailNoDataResponse();

            selectedUser.AuthenticatorType = AuthenticatorType.None;
            _otpAuthenticationWriteRepository.Remove(selectedOtpAuthentication);
            await _unitOfWork.SaveChangesAsync();

            return new SuccesNoDataResponse();
        }
    }
}