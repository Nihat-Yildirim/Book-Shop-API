using BookShopAPI.Application.DTOs.BookPictureDTOs;
using BookShopAPI.Application.DTOs.Common;

namespace BookShopAPI.Application.DTOs.BookDTOs
{
    public class BookDto : IDto
    {
        public int Id { get; set; }
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
        public List<BookPictureDto>? PictureUrls { get; set; }
    }
}