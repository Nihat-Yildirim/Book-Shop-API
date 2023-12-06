using BookShopAPI.Domain.Entities.Common;

namespace BookShopAPI.Domain.Entities
{
    public class District : Entity
    {
        public District()
        {
            Neighbourhoods = new HashSet<Neighbourhood>();
        }

        public int ProvinceId { get; set; }
        public string? Name { get; set; }
        public DateTime? DeletedDate { get; set; }

        public Province? Province { get; set; }
        public ICollection<Address>? Addresses { get; set; }
        public ICollection<Neighbourhood> Neighbourhoods { get; set; }
    }
}