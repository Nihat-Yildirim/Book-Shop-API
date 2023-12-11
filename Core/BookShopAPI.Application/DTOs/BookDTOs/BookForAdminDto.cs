using BookShopAPI.Application.DTOs.AuthorsDTOs;
using BookShopAPI.Application.DTOs.BookPictureDTOs;
using BookShopAPI.Application.DTOs.CategoryDTOs;
using BookShopAPI.Application.DTOs.Common;
using BookShopAPI.Application.DTOs.LanguageDTOs;
using BookShopAPI.Application.DTOs.PublisherDTOs;

namespace BookShopAPI.Application.DTOs.BookDTOs
{
    public class BookForAdminDto : IDto
    {
        public List<BookDto>? Books { get; set; }
        public int BookCount { get; set; }

    }
}