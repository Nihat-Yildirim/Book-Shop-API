using BookShopAPI.Application.DTOs.Common;

namespace BookShopAPI.Application.DTOs.BookSearchDataDTOs
{
    public class BookSearchCountForDaysDto : IDto
    {
        public string? Date { get; set; }
        public int SearchCount { get; set; }
    }
}