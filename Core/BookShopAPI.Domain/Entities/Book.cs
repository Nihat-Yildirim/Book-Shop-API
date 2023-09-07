using BookShopAPI.Domain.Entities.Common;

namespace BookShopAPI.Domain.Entities
{
    public class Book : BaseEntity
    {
        public Book()
        {
            Authors = new HashSet<Author>();
            BookPictures = new HashSet<BookPicture>();
            Categories = new HashSet<Category>();
        }

        public int PublisherId { get; set; }
        public int LanguageId { get; set; }
        public string? BookName { get; set; }
        public string? ISBN { get; set; }
        public string? PaperType { get; set; }
        public string? SkinType { get; set; }
        public string? Dimension { get; set; }
        public string? Description { get; set; }
        public string? ReleaseDate { get; set; }
        public int PageOfNumber { get; set; }
        public int Stock { get; set; }
        public float Price { get; set; }
        public DateTime? DeletedDate { get; set; }

        public Publisher? Publisher { get; set; }
        public Language? Language { get; set; }
        public ICollection<Author> Authors { get; set; }
        public ICollection<Category> Categories { get; set; }
        public ICollection<BasketItem> BasketItems { get; set; }
        public ICollection<BookPicture> BookPictures { get; set; }
    }
}