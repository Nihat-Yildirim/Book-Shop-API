using BookShopAPI.Application.DTOs.Common;

namespace BookShopAPI.Application.DTOs.ViewDTOs
{
    public class ViewCountForDaysDto : IDto
    {
        public string? Date { get; set; }
        public int ViewCount { get; set; }
    }
}