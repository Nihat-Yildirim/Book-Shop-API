using BookShopAPI.Domain.Entities.Common;

namespace BookShopAPI.Domain.Entities
{
    public class Publisher : Entity
    {
        public int PublisherLogoFileId { get; set; }
        public string? Name { get; set; }
        public DateTime? DeletedDate { get; set; }

        public FileEntity? File { get; set; }
        public ICollection<Book>? Books { get; set; }
    }
}