using BookShopAPI.Domain.Entities.Common;

namespace BookShopAPI.Domain.Entities
{
    public class Language : BaseEntity
    {
        public string? Name { get; set; }

        public ICollection<Book>? Books { get; set; }
    }
}