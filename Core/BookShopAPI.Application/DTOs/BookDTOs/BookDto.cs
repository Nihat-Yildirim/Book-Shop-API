using BookShopAPI.Application.DTOs.AuthorsDTOs;
using BookShopAPI.Application.DTOs.CategoryDTOs;
using BookShopAPI.Application.DTOs.Common;
using BookShopAPI.Application.DTOs.LanguageDTOs;
using BookShopAPI.Application.DTOs.PublisherDTOs;

namespace BookShopAPI.Application.DTOs.BookDTOs
{
    public class BookDto : IDto
    {
        public int Id { get; set; }
        public ShortPublisherDto? Publisher { get; set; }
        public ShortLanguageDto? Language { get; set; }
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
        public List<string>? PictureUrls { get; set; }
        public List<ShortAuthorDto>? Authors { get; set; }
        public List<ShortCategoryDto>? Categories { get; set; }
    }
}