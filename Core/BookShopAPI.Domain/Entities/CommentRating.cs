using BookShopAPI.Domain.Entities.Common;

namespace BookShopAPI.Domain.Entities
{
    public class CommentRating : Entity
    {
        public int UserId { get; set; }
        public int CommentId { get; set; }
        public bool Useful { get; set; }
        public DateTime? DeletedDate { get; set; }

        public User? User { get; set; }
        public CommentEntity? Comment { get; set; }
    }
}