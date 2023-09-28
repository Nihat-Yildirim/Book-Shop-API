using BookShopAPI.Application.DTOs.Common;

namespace BookShopAPI.Application.DTOs.BookPictureDTOs
{
    public class BookPictureDto : IDto
    {
        public int Id { get; set; }
        public string? PictureUrl { get; set; }
    }
}