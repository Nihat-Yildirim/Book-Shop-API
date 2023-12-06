using BookShopAPI.Domain.Entities.Common;

namespace BookShopAPI.Domain.Entities
{
    public class View : BaseEntity
    {
        public int BookId { get; set; }

        public Book? Book { get; set; }
    }
}