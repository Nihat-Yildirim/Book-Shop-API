using BookShopAPI.Application.DTOs.Common;

namespace BookShopAPI.Application.DTOs.CommentDTOs
{
    public class ResultCommentForAdminDto : IDto
    {
        public List<CommentForAdminDto>? CommentForAdminDtos { get; set; }
        public int CommentsCount { get; set; }
    }
}