using BookShopAPI.Application.DTOs.Common;

namespace BookShopAPI.Application.DTOs.CommentDTOs
{
    public class ResultPaginationWithCommentDto : IDto
    {
        public List<UserCommentWithBookDataDto>? Comments { get; set; }
        public int CommentsCount { get; set; }
    }
}