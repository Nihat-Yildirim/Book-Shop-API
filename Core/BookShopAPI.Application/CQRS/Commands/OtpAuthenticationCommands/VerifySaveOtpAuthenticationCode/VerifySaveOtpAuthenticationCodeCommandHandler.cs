using BookShopAPI.Application.Helpers.RandomNumber;
using BookShopAPI.Application.OtpAuthenticator;
using BookShopAPI.Application.Repositories.OtpAuthenticationRepositories;
using BookShopAPI.Application.Repositories.UserRepositories;
using BookShopAPI.Application.UnitOfWork;
using BookShopAPI.Domain.Enums;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookShopAPI.Application.CQRS.Commands.OtpAuthenticationCommands.VerifySaveOtpAuthenticationCode
{
    public class VerifySaveOtpAuthenticationCodeCommandHandler : IRequestHandler<VerifySaveOtpAuthenticationCodeCommandRequest, BaseDataResponse<List<string>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IOtpAuthenticator _otpAuthenticator;
        private readonly IUserReadRepository _userReadRepository;
        private readonly IOtpAuthenticationReadRepository _otpAuthenticationReadRepository;

        public VerifySaveOtpAuthenticationCodeCommandHandler(IUnitOfWork unitOfWork, IOtpAuthenticator otpAuthenticator, IUserReadRepository userReadRepository, IOtpAuthenticationReadRepository otpAuthenticationReadRepository)
        {
            _unitOfWork = unitOfWork;
            _otpAuthenticator = otpAuthenticator;
            _userReadRepository = userReadRepository;
            _otpAuthenticationReadRepository = otpAuthenticationReadRepository;
        }

        public async Task<BaseDataResponse<List<string>>> Handle(VerifySaveOtpAuthenticationCodeCommandRequest request, CancellationToken cancellationToken)
        {
            var selectedUser = await _userReadRepository.GetSingleAsync(x => x.Email == request.Email && x.DeletedDate == null && x.AuthenticatorType == AuthenticatorType.Otp);
            if (selectedUser == null)
                return new FailDataResponse<List<string>>();

            var selectedOtpAuthentication = await _otpAuthenticationReadRepository.Table
                                                    .Include(x => x.OtpRecoveryCodes)
                                                    .SingleOrDefaultAsync(x => x.Id == selectedUser.Id);

            bool isVerify = _otpAuthenticator.VerifyCode(selectedOtpAuthentication.SecretKey, request.Code);
            if (!isVerify)
                return new FailDataResponse<List<string>>();

            selectedOtpAuthentication.OtpRecoveryCodes.ToList().ForEach(recoveryCode =>
            {
                recoveryCode.Code = RandomNumberHelper.GenerateNumberToString(6);
            });

            await _unitOfWork.SaveChangesAsync();

            return new SuccessDataResponse<List<string>>(selectedOtpAuthentication.OtpRecoveryCodes.Select(x => x.Code).ToList());
        }
    }
}
