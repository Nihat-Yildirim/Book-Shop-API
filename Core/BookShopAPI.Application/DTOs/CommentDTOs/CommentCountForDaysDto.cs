using BookShopAPI.Application.DTOs.Common;

namespace BookShopAPI.Application.DTOs.CommentDTOs
{
    public class CommentCountForDaysDto : IDto
    {
        public string? Date { get; set; }
        public int CommentCount { get; set; }
    }
}