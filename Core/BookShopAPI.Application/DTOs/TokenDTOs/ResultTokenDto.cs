using BookShopAPI.Application.DTOs.Common;
using BookShopAPI.Domain.Tokens;

namespace BookShopAPI.Application.DTOs.TokenDTOs
{
    public class ResultTokenDto : IDto
    {
        public AccessToken? AccessToken { get; set; }
        public RefreshToken? RefreshToken { get; set; }
        public int UserId { get; set; }
    }
}