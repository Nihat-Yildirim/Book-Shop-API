using BookShopAPI.Domain.Entities.Common;

namespace BookShopAPI.Domain.Entities
{
    public class Address : BaseEntity
    {
        public int UserId { get; set; }
        public string? AddressTitle { get; set; }
        public string? Description { get; set; }
        public string? Province { get; set; }
        public string? District { get; set; }
        public string? Neighbourhood { get; set; }
        public string? OpenAddress { get; set; }
        public bool Selected { get; set; }
        public DateTime? DeletedDate { get; set; }

        public User? User { get; set; }
    }
}