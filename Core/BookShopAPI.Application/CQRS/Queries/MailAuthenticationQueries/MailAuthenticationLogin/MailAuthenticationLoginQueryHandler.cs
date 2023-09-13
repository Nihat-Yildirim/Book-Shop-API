using BookShopAPI.Application.DTOs.TokenDTOs;
using BookShopAPI.Application.DTOs.UserDTOs;
using BookShopAPI.Application.Helpers.RandomNumber;
using BookShopAPI.Application.Mailing;
using BookShopAPI.Application.Repositories.MailAuthenticationRepositories;
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

namespace BookShopAPI.Application.CQRS.Queries.MailAuthenticationQueries.MailAuthenticationLogin
{
    public class MailAuthenticationLoginQueryHandler : IRequestHandler<MailAuthenticationLoginQueryRequest, BaseDataResponse<LoginResultDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMailService _mailService;
        private readonly IUserReadRepository _userReadRepository;
        private readonly IAccessTokenService _accessTokenService;
        private readonly IRefreshTokenService _refreshTokenService;
        private readonly IMailAuthenticationReadRepository _mailAuthenticationReadRepository;

        public MailAuthenticationLoginQueryHandler(IUnitOfWork unitOfWork, IMailService mailService, IUserReadRepository userReadRepository, IAccessTokenService accessTokenService, IRefreshTokenService refreshTokenService, IMailAuthenticationReadRepository mailAuthenticationReadRepository)
        {
            _unitOfWork = unitOfWork;
            _mailService = mailService;
            _userReadRepository = userReadRepository;
            _accessTokenService = accessTokenService;
            _refreshTokenService = refreshTokenService;
            _mailAuthenticationReadRepository = mailAuthenticationReadRepository;
        }

        public async Task<BaseDataResponse<LoginResultDto>> Handle(MailAuthenticationLoginQueryRequest request, CancellationToken cancellationToken)
        {
            var selectedUser = await _userReadRepository.Table
                                .Include(x => x.UserClaim)
                                    .ThenInclude(x => x.Claim)
                                .Include(x => x.RefreshToken)
                                .SingleOrDefaultAsync(x => x.Email == request.Email && x.AuthenticatorType == AuthenticatorType.Email && x.DeletedDate == null);
            
            if (selectedUser == null)
                return new FailDataResponse<LoginResultDto>();

            var selectedMailAuthentication = await _mailAuthenticationReadRepository.GetByIdAsync(selectedUser.Id);
            if (selectedMailAuthentication == null)
                return new FailDataResponse<LoginResultDto>();

            if(selectedMailAuthentication.ActivationDuration < DateTime.Now)
            {
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
                return new FailDataResponse<LoginResultDto>();
            }

            if (selectedMailAuthentication.ActivationKey != request.Code)
                return new FailDataResponse<LoginResultDto>();

            selectedMailAuthentication.IsVerified = true;

            List<Claim> claims = new();
            claims.Add(selectedUser.UserClaim.Claim);

            var accessToken = _accessTokenService.CreateAccessToken(selectedUser, claims);
            var refreshToken = _refreshTokenService.CreateRefreshToken();

            if (selectedUser.RefreshToken == null)
                selectedUser.RefreshToken = new()
                {
                    Expires = refreshToken.Expiration,
                    Token = refreshToken.Token
                };

            if (selectedUser.RefreshToken != null)
            {
                selectedUser.RefreshToken.Expires = refreshToken.Expiration;
                selectedUser.RefreshToken.Token = refreshToken.Token;
            }
            await _unitOfWork.SaveChangesAsync();

            TokenDto token = new();
            token.AccessToken = accessToken;
            token.RefreshToken = refreshToken;

            LoginResultDto loginResult = new();
            loginResult.Authenticator = selectedUser.AuthenticatorType;
            loginResult.UserId = selectedUser.Id;
            loginResult.Token = token;

            return new SuccessDataResponse<LoginResultDto>(loginResult);
        }
    }
}