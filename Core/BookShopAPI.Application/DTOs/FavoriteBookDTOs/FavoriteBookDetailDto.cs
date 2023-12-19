using BookShopAPI.Application.DTOs.Common;

namespace BookShopAPI.Application.DTOs.FavoriteBookDTOs
{
    public class FavoriteBookDetailDto : IDto
    {
        public int FavoriteId { get; set; }
        public int BookId { get; set; }
        public string? BookName { get; set; }
        public float Price { get; set; }
        public string? PictureUrl { get; set; }
    }
}