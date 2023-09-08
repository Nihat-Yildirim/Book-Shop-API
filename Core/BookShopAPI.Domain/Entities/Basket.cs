using BookShopAPI.Domain.Entities.Common;

namespace BookShopAPI.Domain.Entities
{
    public class Basket : BaseEntity
    {
        public Basket()
        {
            BasketItems = new HashSet<BasketItem>();
        }

        public int UserId { get; set; }
        public bool? Visible { get; set; }

        public User? User { get; set; }
        public Order? Order { get; set; }
        public ICollection<BasketItem>? BasketItems { get; set; }
    }
}