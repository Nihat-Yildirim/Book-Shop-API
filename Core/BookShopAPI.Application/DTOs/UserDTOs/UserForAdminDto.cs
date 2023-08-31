using BookShopAPI.Application.DTOs.Common;

namespace BookShopAPI.Application.DTOs.UserDTOs
{
    public class UserForAdminDto : IDto
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime DeletedDate { get; set; }
    }
}