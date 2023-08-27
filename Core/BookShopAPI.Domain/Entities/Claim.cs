using BookShopAPI.Domain.Entities.Common;

namespace BookShopAPI.Domain.Entities
{
    public class Claim : BaseEntity
    {
        public Claim()
        {
            UserClaims = new HashSet<UserClaim>();
        }

        public string? Name { get; set; }
        public DateTime DeletedDate { get; set; }

        public ICollection<UserClaim> UserClaims { get; set; }
    }
}