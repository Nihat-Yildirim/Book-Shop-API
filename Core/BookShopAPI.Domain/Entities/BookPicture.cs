using BookShopAPI.Domain.Entities.Common;

namespace BookShopAPI.Domain.Entities
{
    public class BookPicture : BaseEntity
    {
        public int BookId { get; set; }
        public int BookPictureFileId { get; set; }
        public int ShowOrder { get; set; }

        public FileEntity? File { get; set; }
        public Book? Book { get; set; }
    }
}