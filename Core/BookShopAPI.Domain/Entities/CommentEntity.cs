using BookShopAPI.Domain.Entities.Common;

namespace BookShopAPI.Domain.Entities
{
    public class CommentEntity : Entity
    {
        public int BookId { get; set; }
        public int UserId { get; set; }
        public int? ParentCommentId { get; set; }
        public string? Comment { get; set; }
        public DateTime? DeletedDate { get; set; }

        public Book? Book { get; set; }
        public User? User { get; set; }
        public ICollection<CommentRating>? CommentRatings { get; set; }
    }
}