using BookShopAPI.Application.DTOs.Common;
using BookShopAPI.Application.DTOs.FavoriteBookDTOs;

namespace BookShopAPI.Application.DTOs.BookDTOs
{
    public class ResultFavoriteBookDto : IDto
    {
        public List<FavoriteBookDetailDto>? FavoriteBooks { get; set; }
        public int FavoriteBookCount { get; set; }
    }
}