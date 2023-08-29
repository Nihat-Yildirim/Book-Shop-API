using BookShopAPI.Domain.Tokens;

namespace BookShopAPI.Application.Tokens
{
    public interface IRefreshTokenService
    {
        RefreshToken CreateRefreshToken();
    }
}