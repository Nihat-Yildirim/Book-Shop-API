using BookShopAPI.Application.DTOs.TokenDTOs;
using BookShopAPI.Application.DTOs.UserDTOs;
using BookShopAPI.Application.Helpers.Hashing;
using BookShopAPI.Application.Helpers.RandomNumber;
using BookShopAPI.Application.Mailing;
using BookShopAPI.Application.Repositories.MailAuthenticationRepositories;
using BookShopAPI.Application.Repositories.UserClaimRepositories;
using BookShopAPI.Application.Repositories.UserRepositories;
using BookShopAPI.Application.Tokens;
using BookShopAPI.Application.UnitOfWork;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Domain.Enums;
using BookShopAPI.Domain.Mailing;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookShopAPI.Application.CQRS.Queries.UserQueries.Login
{
    public class LoginQueryHandler : IRequestHandler<LoginQueryRequest, BaseDataResponse<LoginResultDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMailService _mailService;
        private readonly IAccessTokenService _accessTokenService;
        private readonly IRefreshTokenService _refreshTokenService;
        private readonly IUserReadRepository _userReadRepository;
        private readonly IUserClaimReadRepository _userClaimReadRepository;
        private readonly IMailAuthenticationReadRepository _mailAuthenticationReadRepository;
        private readonly IMailAuthenticationWriteRepository _mailAuthenticationWriteRepository;
        public LoginQueryHandler(IAccessTokenService accessTokenService, IRefreshTokenService refreshTokenService, IUserReadRepository userReadRepository, IUserClaimReadRepository userClaimReadRepository, IUnitOfWork unitOfWork, IMailService mailService)
        {
            _unitOfWork = unitOfWork;
            _mailService = mailService;
            _accessTokenService = accessTokenService;
            _refreshTokenService = refreshTokenService;
            _userReadRepository = userReadRepository;
            _userClaimReadRepository = userClaimReadRepository;
        }

        public async Task<BaseDataResponse<LoginResultDto>> Handle(LoginQueryRequest request, CancellationToken cancellationToken)
        {
            var selectedUser = await _userReadRepository.Table
                                .Include(x => x.RefreshToken)
                                .Include(x => x.MailComfirmCode)
                                .SingleOrDefaultAsync(x => x.Email == request.Email);

            if (selectedUser == null)
                return new FailDataResponse<LoginResultDto>();

            if (!selectedUser.MailComfirmCode.IsComfirm)
                return new FailDataResponse<LoginResultDto>();

            if (selectedUser.DeletedDate != default)
                return new FailDataResponse<LoginResultDto>();

            var isVerify = HashingHelper.VerifyPasswordHash(request.Password, selectedUser.PasswordHash, selectedUser.PasswordSalt);
            if (!isVerify)
                return new FailDataResponse<LoginResultDto>();

            if (selectedUser.AuthenticatorType == AuthenticatorType.Email)
                return await MailAuthenticatorLoginAsync(selectedUser);

            if(selectedUser.AuthenticatorType == AuthenticatorType.Otp)
                return OtpAuthenticatorLogin(selectedUser);

            return await NoneAuthenticatorLoginAsync(selectedUser);
        }

        private async Task<BaseDataResponse<LoginResultDto>> NoneAuthenticatorLoginAsync(User selectedUser)
        {
            var userClaims = await _userClaimReadRepository.GetWhere(x => x.UserId == selectedUser.Id).Include(x => x.Claim).ToListAsync();
            var refreshToken = _refreshTokenService.CreateRefreshToken();
            var accessToken = _accessTokenService.CreateAccessToken(selectedUser, userClaims.Select(x => x.Claim).ToList());

            if (selectedUser.RefreshToken == null)
                selectedUser.RefreshToken = new()
                {
                    Token = refreshToken.Token,
                    Expires = refreshToken.Expiration,
                };

            if (selectedUser.RefreshToken != null)
            {
                selectedUser.RefreshToken.Token = refreshToken.Token;
                selectedUser.RefreshToken.Expires = refreshToken.Expiration;
            }
            await _unitOfWork.SaveChangesAsync();

            TokenDto resultToken = new()
            {
                AccessToken = accessToken,
                RefreshToken = refreshToken,
            };

            LoginResultDto loginResult = new();
            loginResult.Token = resultToken;
            loginResult.UserId = selectedUser.Id;
            loginResult.Authenticator = AuthenticatorType.None;

            return new SuccessDataResponse<LoginResultDto>(loginResult);
        }

        private BaseDataResponse<LoginResultDto> OtpAuthenticatorLogin(User selectedUser)
        {
            LoginResultDto loginResult = new();
            loginResult.Authenticator = AuthenticatorType.Otp;
            loginResult.Token = null;

            return new SuccessDataResponse<LoginResultDto>(loginResult);
        }

        private async Task<BaseDataResponse<LoginResultDto>> MailAuthenticatorLoginAsync(User selectedUser)
        {
            var selectedMailAuthentication = await _mailAuthenticationReadRepository.GetSingleAsync(x => x.Id == selectedUser.Id);
            var activationCode = RandomNumberHelper.GenerateNumberToString(6);
            selectedMailAuthentication.ActivationKey = activationCode;
            selectedMailAuthentication.ActivationDuration = DateTime.Now.AddDays(1);
            selectedMailAuthentication.IsVerified = false;
            await _unitOfWork.SaveChangesAsync();

            Mail mail = new()
            {
                Subject = "Doğrulama Kodu",
                TextBody = "Lütfen giriş yapabilmek için aşağıdaki kodu ilgili alana giriniz",
                HtmlBody = $"<h5>{activationCode}</h5>",
                ToEmail = selectedUser.Email,
                ToFullName = selectedUser.FirstName + " " + selectedUser.LastName,
            };

            await _mailService.SendAsync(mail);

            LoginResultDto loginResultDto = new();
            loginResultDto.Authenticator = AuthenticatorType.Email;

            return new SuccessDataResponse<LoginResultDto>(loginResultDto);
        }
    }
}