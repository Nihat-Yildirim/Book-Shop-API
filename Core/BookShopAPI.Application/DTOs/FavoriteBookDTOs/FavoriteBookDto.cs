using BookShopAPI.Application.DTOs.Common;

namespace BookShopAPI.Application.DTOs.FavoriteBookDTOs
{
    public class FavoriteBookDto : IDto
    {
        public int Id { get; set; }
        public int BookId { get; set; }
    }
}