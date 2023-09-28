using BookShopAPI.Domain.Entities.Common;

namespace BookShopAPI.Domain.Entities
{
    public class Author : BaseEntity
    {
        public int? AuthorPictureFileId { get; set; }
        public string? Name { get; set; }
        public string? Autobiography { get; set; }
        public DateTime? DeletedDate { get; set; }

        public FileEntity? File { get; set; }
        public ICollection<Book>? Books { get; set; }
    }
}