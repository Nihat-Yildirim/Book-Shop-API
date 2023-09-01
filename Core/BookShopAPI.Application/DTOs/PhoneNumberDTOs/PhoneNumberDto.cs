using BookShopAPI.Application.DTOs.Common;

namespace BookShopAPI.Application.DTOs.PhoneNumberDTOs
{
    public class PhoneNumberDto : IDto
    {
        public int Id { get; set; }
        public string? PhoneTitle { get; set; }
        public string? PhoneNumber { get; set; }
        public bool Selected { get; set; }
    }
}