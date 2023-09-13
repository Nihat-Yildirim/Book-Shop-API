using BookShopAPI.Application.DTOs.Common;

namespace BookShopAPI.Application.DTOs.CommentDTOs
{
    public class CommentForAdminDto : IDto
    {
        public int UserId { get; set; }
        public int BookId { get; set; }
        public int? ParentCommentId { get; set; }
        public int CommentId { get; set; }
        public string? Comment { get; set; }
        public int TotalRating { get; set; }
        public int TotalUsefulRating { get; set; }
        public int TotalNotUsefulRating { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}