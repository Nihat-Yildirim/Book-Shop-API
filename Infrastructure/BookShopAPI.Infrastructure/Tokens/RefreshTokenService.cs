using BookShopAPI.Application.Tokens;
using BookShopAPI.Domain.Tokens;
using BookShopAPI.Domain.Tokens.Options;
using BookShopAPI.Infrastructure.Helpers;

namespace BookShopAPI.Infrastructure.Tokens
{
    public class RefreshTokenService : IRefreshTokenService
    {
        private RefreshTokenOptions _refreshTokenOptions;
        public RefreshTokenService()
        {
            _refreshTokenOptions = RefreshTokenOptionsHelper.GetRefreshTokenOptions();
        }

        public RefreshToken CreateRefreshToken()
        {
            return new()
            {
                Token = Guid.NewGuid().ToString(),
                Expiration = DateTime.Now.AddHours(_refreshTokenOptions.RefreshTokenExpirationHour)
            };
        }
    }
}