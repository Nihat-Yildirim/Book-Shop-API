using BookShopAPI.Application.DTOs.Common;
using BookShopAPI.Domain.Enums;

namespace BookShopAPI.Application.DTOs.CommentDTOs
{
    public class CommentDto : IDto
    {
        public int UserId { get; set; }
        public int CommentId { get; set; }
        public string? UserName { get; set; }
        public string? UserPictureUrl { get; set; }
        public string? Comment { get; set; }
        public int TotalUsefulRating { get; set; }
        public int TotalNotUsefulRating { get; set; }
        public DateTime CreatedDate { get; set; }
        public UserSelectCommentRating SelectedCommentRating { get; set; }
    }
}