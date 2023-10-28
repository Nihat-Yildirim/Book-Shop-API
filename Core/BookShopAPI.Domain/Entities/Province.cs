using BookShopAPI.Domain.Entities.Common;

namespace BookShopAPI.Domain.Entities
{
    public class Province : BaseEntity
    {
        public Province()
        {
            Districts = new HashSet<District>();
        }

        public string? Name { get; set; }
        public DateTime? DeletedDate { get; set; }

        public ICollection<District> Districts { get; set; }
        public ICollection<Address>? Addresses { get; set; }
    }
}