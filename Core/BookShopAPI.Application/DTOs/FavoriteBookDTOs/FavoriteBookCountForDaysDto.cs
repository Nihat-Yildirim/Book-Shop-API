using BookShopAPI.Application.DTOs.Common;

namespace BookShopAPI.Application.DTOs.FavoriteBookDTOs
{
    public class FavoriteBookCountForDaysDto : IDto
    {
        public string? Date { get; set; }
        public int FavoriteBookCount { get; set; }
    }
}