using BookShopAPI.Application.DTOs.Common;

namespace BookShopAPI.Application.DTOs.CommentDTOs
{
    public class ResultCommentDto : IDto
    {
        public List<CommentDto>? Comments { get; set; }
        public int CommentsCount { get; set; }
    }
}