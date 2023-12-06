using BookShopAPI.Application.DTOs.Common;
using BookShopAPI.Application.DTOs.TokenDTOs;
using BookShopAPI.Domain.Enums;

namespace BookShopAPI.Application.DTOs.UserDTOs
{
    public class LoginResultDto : IDto
    {
        public AuthenticatorType Authenticator { get; set; }
        public int UserId { get; set; }
        public bool IsAdmin { get; set; }
        public TokenDto? Token { get; set; }
    }
}