using BookShopAPI.Domain.Entities.Common;

namespace BookShopAPI.Domain.Entities
{
    public class Neighbourhood : BaseEntity
    {
        public int DistrictId { get; set; }
        public string? Name { get; set; }
        public DateTime? DeletedDate { get; set; }

        public District? District { get; set; }
        public ICollection<Address>? Addresses { get; set; }
    }
}