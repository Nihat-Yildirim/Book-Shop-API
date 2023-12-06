using BookShopAPI.Domain.Entities.Common;

namespace BookShopAPI.Domain.Entities
{
    public class RefreshToken : Entity
    {
        public string? Token { get; set; }
        public DateTime Expires { get; set; }

        public User? User { get; set; }
    }
}