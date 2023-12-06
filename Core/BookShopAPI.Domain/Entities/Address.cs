using BookShopAPI.Domain.Entities.Common;

namespace BookShopAPI.Domain.Entities
{
    public class Address : Entity
    {
        public int UserId { get; set; }
        public int ProvinceId { get; set; }
        public int DistrictId { get; set; }
        public string? PhoneNumber { get; set; }
        public int NeighbourhoodId { get; set; }
        public string? AddressTitle { get; set; }
        public string? Description { get; set; }
        public string? OpenAddress { get; set; }
        public bool Selected { get; set; }
        public DateTime? DeletedDate { get; set; }

        public User? User { get; set; }
        public Province? Province { get; set; }
        public District? District { get; set; }
        public Neighbourhood? Neighbourhood { get; set; }
        public ICollection<Order>? Orders { get; set; }
    }
}