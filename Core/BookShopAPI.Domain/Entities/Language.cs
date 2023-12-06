using BookShopAPI.Domain.Entities.Common;

namespace BookShopAPI.Domain.Entities
{
    public class Language : Entity
    {
        public string? Name { get; set; }

        public ICollection<Book>? Books { get; set; }
    }
}