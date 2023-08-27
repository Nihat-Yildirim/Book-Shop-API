using BookShopAPI.Domain.Entities.Common;

namespace BookShopAPI.Domain.Entities
{
    public class Category : BaseEntity
    {
        public int ParentId { get; set; }
        public string? CategoryName { get; set; }
        public DateTime DeletedDate { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}