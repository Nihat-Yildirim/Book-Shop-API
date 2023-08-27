using BookShopAPI.Domain.Entities.Common;

namespace BookShopAPI.Domain.Entities
{
    public class UserClaim : BaseEntity
    {
        public int UserId { get; set; }
        public int ClaimId { get; set; }

        public User? User { get; set; }
        public Claim? Claim { get; set; }
    }
}