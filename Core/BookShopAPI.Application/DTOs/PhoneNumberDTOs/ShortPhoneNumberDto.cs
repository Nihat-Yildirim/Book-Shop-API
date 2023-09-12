using BookShopAPI.Application.DTOs.Common;

namespace BookShopAPI.Application.DTOs.PhoneNumberDTOs
{
    public class ShortPhoneNumberDto : IDto
    {
        public int Id { get; set; }
        public string? PhoneNumber { get; set; }
    }
}