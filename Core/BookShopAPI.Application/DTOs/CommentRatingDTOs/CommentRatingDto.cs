using BookShopAPI.Application.DTOs.Common;

namespace BookShopAPI.Application.DTOs.CommentRatingDTOs
{
    public class CommentRatingDto : IDto
    {
        public int CommentRatingId { get; set; }
        public bool Useful { get; set; }
    }
}