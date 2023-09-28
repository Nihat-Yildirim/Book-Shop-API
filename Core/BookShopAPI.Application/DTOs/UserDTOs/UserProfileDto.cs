using BookShopAPI.Application.DTOs.Common;
using BookShopAPI.Domain.Enums;

namespace BookShopAPI.Application.DTOs.UserDTOs
{
    public class UserProfileDto : IDto
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? PictureUrl { get; set; }
        public int BasketId { get; set; }
        public AuthenticatorType AuthenticatorType { get; set; }
    }
}