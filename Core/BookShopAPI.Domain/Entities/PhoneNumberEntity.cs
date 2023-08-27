using BookShopAPI.Domain.Entities.Common;

namespace BookShopAPI.Domain.Entities
{
    public class PhoneNumberEntity : BaseEntity
    {
        public int UserId { get; set; }
        public string? PhoneTitle { get; set; }
        public string? PhoneNumber { get; set; }
        public bool View { get; set; }
        public DateTime DeletedDate { get; set; }

        public User? User { get; set; }
    }
}