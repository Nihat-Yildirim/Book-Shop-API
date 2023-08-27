using BookShopAPI.Domain.Entities.Common;

namespace BookShopAPI.Domain.Entities
{
    public class Store : BaseEntity
    {
        public Store()
        {
            Books = new HashSet<Book>();
        }

        public int StoreLogoFileId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime DeletedDate { get; set; }

        public User? User { get; set; }
        public File? File { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}