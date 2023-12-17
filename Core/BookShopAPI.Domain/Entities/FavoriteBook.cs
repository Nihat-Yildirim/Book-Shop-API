using BookShopAPI.Domain.Entities.Common;

namespace BookShopAPI.Domain.Entities
{
    public class FavoriteBook : BaseEntity
    {
        public int UserId { get; set; }
        public int BookId { get; set; }


        public Book? Book { get; set; }
        public User? User { get; set; }
    }
}