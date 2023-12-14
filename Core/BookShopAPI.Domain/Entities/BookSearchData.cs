using BookShopAPI.Domain.Entities.Common;

namespace BookShopAPI.Domain.Entities
{
    public class BookSearchData : BaseEntity
    {
        public int BookId { get; set; }

        public Book? Book { get; set; }
    }
}