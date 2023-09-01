using BookShopAPI.Application.DTOs.Common;

namespace BookShopAPI.Application.DTOs.PhoneNumberDTOs
{
    public class PhoneNumberForAdminDto : IDto
    {
        public int Id { get; set; }
        public string? PhoneTitle { get; set; }
        public string? PhoneNumber { get; set; }
        public bool Selected { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime DeletedDate { get; set; }
    }
}