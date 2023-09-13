using BookShopAPI.Application.DTOs.Common;
using BookShopAPI.Domain.Tokens;

namespace BookShopAPI.Application.DTOs.TokenDTOs
{
    public class TokenDto : IDto
    {
        public AccessToken? AccessToken { get; set; }
        public RefreshToken? RefreshToken { get; set; }
    }
}