using BookShopAPI.Domain.Entities;
using BookShopAPI.Domain.Tokens;

namespace BookShopAPI.Application.Tokens
{
    public interface IAccessTokenService
    {
        AccessToken CreateAccessToken(User user, List<Claim> roles);
    }
}