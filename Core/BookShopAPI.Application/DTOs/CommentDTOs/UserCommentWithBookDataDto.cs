using BookShopAPI.Application.DTOs.Common;

namespace BookShopAPI.Application.DTOs.CommentDTOs
{
    public class UserCommentWithBookDataDto : IDto
    {
        public int UserId { get; set; }
        public int CommentId { get; set; }
        public string? Comment { get; set; }
        public int TotalUsefulRating { get; set; }
        public int TotalNotUsefulRating { get; set; }
        public DateTime CreatedDate { get; set; }
        public int BookId { get; set; }
        public string? BookName { get; set; }
        public string? BookPictureUrl { get; set; }
    }
}