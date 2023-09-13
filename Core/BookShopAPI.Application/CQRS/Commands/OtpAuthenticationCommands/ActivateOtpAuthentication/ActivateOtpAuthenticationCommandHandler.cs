using BookShopAPI.Application.Helpers.RandomNumber;
using BookShopAPI.Application.OtpAuthenticator;
using BookShopAPI.Application.Repositories.OtpAuthenticationRepositories;
using BookShopAPI.Application.Repositories.OtpRecoveryCodeRepositories;
using BookShopAPI.Application.Repositories.UserRepositories;
using BookShopAPI.Application.UnitOfWork;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Domain.Enums;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.OtpAuthenticationCommands.ActivateOtpAuthentication
{
    public class ActivateOtpAuthenticationCommandHandler : IRequestHandler<ActivateOtpAuthenticationCommandRequest, BaseDataResponse<List<string>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IOtpAuthenticator _otpAuthenticator;
        private readonly IUserReadRepository _userReadRepository;
        private readonly IOtpAuthenticationReadRepository _otpAuthenticationReadRepository;
        private readonly IOtpRecoveryCodeWriteRepository _otpRecoveryCodeWriteRepository;

        public ActivateOtpAuthenticationCommandHandler(IUnitOfWork unitOfWork, IOtpAuthenticator otpAuthenticator, IUserReadRepository userReadRepository, IOtpAuthenticationReadRepository otpAuthenticationReadRepository, IOtpRecoveryCodeWriteRepository otpRecoveryCodeWriteRepository)
        {
            _unitOfWork = unitOfWork;
            _otpAuthenticator = otpAuthenticator;
            _userReadRepository = userReadRepository;
            _otpAuthenticationReadRepository = otpAuthenticationReadRepository;
            _otpRecoveryCodeWriteRepository = otpRecoveryCodeWriteRepository;
        }

        public async Task<BaseDataResponse<List<string>>> Handle(ActivateOtpAuthenticationCommandRequest request, CancellationToken cancellationToken)
        {
            var selectedUser = await _userReadRepository.GetSingleAsync(x => x.Email == request.Email && x.DeletedDate == null && x.AuthenticatorType == AuthenticatorType.None);
            if (selectedUser == null)
                return new FailDataResponse<List<string>>();

            var selectedOtpAuthentication = await _otpAuthenticationReadRepository.GetByIdAsync(selectedUser.Id);
            if (selectedOtpAuthentication == null)
                return new FailDataResponse<List<string>>();

            bool isVerify = _otpAuthenticator.VerifyCode(selectedOtpAuthentication.SecretKey, request.ActivationCode);
            if (!isVerify)
                return new FailDataResponse<List<string>>();

            List<OtpRecoveryCode> otpRecoveryCodes = new();
            for(int i = 0; i < 6; i++)
            {
                OtpRecoveryCode recoveryCode = new()
                {
                    Code = RandomNumberHelper.GenerateNumberToString(6),
                    OtpAuthenticationId = selectedOtpAuthentication.Id,
                };
                otpRecoveryCodes.Add(recoveryCode);
            }

            selectedUser.AuthenticatorType = AuthenticatorType.Otp;
            selectedOtpAuthentication.IsVerified = true;
            await _otpRecoveryCodeWriteRepository.AddRangeAsync(otpRecoveryCodes);
            await _unitOfWork.SaveChangesAsync();

            return new SuccessDataResponse<List<string>>(otpRecoveryCodes.Select(x => x.Code).ToList());
        }
    }
}