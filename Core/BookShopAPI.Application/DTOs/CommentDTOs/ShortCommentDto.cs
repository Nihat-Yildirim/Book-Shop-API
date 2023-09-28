using BookShopAPI.Application.DTOs.Common;

namespace BookShopAPI.Application.DTOs.CommentDTOs
{
    public class ShortCommentDto : IDto
    {
        public int CommentId { get; set; }
        public string? Comment { get; set; }
        public int TotalUsefulRating { get; set; }
        public int TotalNotUsefulRating { get; set; }
    }
}