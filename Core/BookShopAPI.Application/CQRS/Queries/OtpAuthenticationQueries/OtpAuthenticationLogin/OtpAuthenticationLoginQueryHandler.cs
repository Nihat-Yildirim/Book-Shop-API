using BookShopAPI.Application.DTOs.TokenDTOs;
using BookShopAPI.Application.DTOs.UserDTOs;
using BookShopAPI.Application.OtpAuthenticator;
using BookShopAPI.Application.Repositories.UserRepositories;
using BookShopAPI.Application.Tokens;
using BookShopAPI.Application.UnitOfWork;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Domain.Enums;
using BookShopAPI.Domain.Results.Abstracts;
using BookShopAPI.Domain.Results.Concretes;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookShopAPI.Application.CQRS.Queries.OtpAuthenticationQueries.OtpAuthenticationLogin
{
    public class OtpAuthenticationLoginQueryHandler : IRequestHandler<OtpAuthenticationLoginQueryRequest, BaseDataResponse<LoginResultDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IOtpAuthenticator _otpAuthenticator;
        private readonly IAccessTokenService _accessTokenService;
        private readonly IUserReadRepository _userReadRepository;
        private readonly IRefreshTokenService _refreshTokenService;

        public OtpAuthenticationLoginQueryHandler(IUnitOfWork unitOfWork, IOtpAuthenticator otpAuthenticator, IAccessTokenService accessTokenService, IRefreshTokenService refreshTokenService, IUserReadRepository userReadRepository)
        {
            _unitOfWork = unitOfWork;
            _otpAuthenticator = otpAuthenticator;
            _accessTokenService = accessTokenService;
            _userReadRepository = userReadRepository;
            _refreshTokenService = refreshTokenService;
        }

        public async Task<BaseDataResponse<LoginResultDto>> Handle(OtpAuthenticationLoginQueryRequest request, CancellationToken cancellationToken)
        {
            var selectedUser = await _userReadRepository.Table
                                .Include(x => x.UserClaim)
                                .ThenInclude(x => x.Claim)
                                .Include(x => x.OtpAuthentication)
                                .Include(x => x.RefreshToken)
                                .SingleOrDefaultAsync(x => x.Email == request.Email && x.AuthenticatorType == AuthenticatorType.Otp && x.DeletedDate == null);

            if(selectedUser == null || selectedUser.OtpAuthentication == null)
                return new FailDataResponse<LoginResultDto>();

            bool isVerify = _otpAuthenticator.VerifyCode(selectedUser.OtpAuthentication.SecretKey, request.Code);
            if(!isVerify)
                return new FailDataResponse<LoginResultDto>();

            List<Claim> claims = new();
            claims.Add(selectedUser.UserClaim.Claim);

            var accessToken = _accessTokenService.CreateAccessToken(selectedUser, claims);
            var refreshToken = _refreshTokenService.CreateRefreshToken();

            if(selectedUser.RefreshToken == null)
                selectedUser.RefreshToken = new()
                {
                    Expires = refreshToken.Expiration,
                    Token = refreshToken.Token
                };

            if(selectedUser.RefreshToken != null)
            {
                selectedUser.RefreshToken.Expires = refreshToken.Expiration;
                selectedUser.RefreshToken.Token = refreshToken.Token;
            }
            await _unitOfWork.SaveChangesAsync();

            TokenDto token = new();
            token.AccessToken = accessToken;
            token.RefreshToken = refreshToken;

            LoginResultDto loginResult = new();
            loginResult.IsAdmin = claims.Any(x => x.Name == "Admin");
            loginResult.Authenticator = selectedUser.AuthenticatorType;
            loginResult.UserId = selectedUser.Id;
            loginResult.Token = token;

            return new SuccessDataResponse<LoginResultDto>(loginResult);
        }
    }
}