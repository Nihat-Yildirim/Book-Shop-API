using BookShopAPI.Application.DTOs.Common;

namespace BookShopAPI.Application.DTOs.CommentDTOs
{
    public class CommentForAdminDto : IDto
    {
        public int UserId { get; set; }
        public int CommentId { get; set; }
        public int BookId { get; set; }
        public string? UserFirstName { get; set; }
        public string? UserLastName { get; set; }
        public string? PictureUrl { get; set; }
        public int? ParentCommentId { get; set; }
        public string? Comment { get; set; }
        public int UsefulRating { get; set; }
        public int NotUsefulRating { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}