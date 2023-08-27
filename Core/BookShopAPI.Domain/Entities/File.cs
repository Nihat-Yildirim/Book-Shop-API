using BookShopAPI.Domain.Entities.Common;

namespace BookShopAPI.Domain.Entities
{
    public class File : BaseEntity
    {
        public string? FileName { get; set; }
        public string? FilePath { get; set; }
        public string? FileExtension { get; set; }

        public User? User { get; set; }
        public Store? Store { get; set; }
        public Author? Author { get; set; }
        public Publisher? Publisher { get; set; }
        public BookPicture? BookPicture { get; set; }
    }
}