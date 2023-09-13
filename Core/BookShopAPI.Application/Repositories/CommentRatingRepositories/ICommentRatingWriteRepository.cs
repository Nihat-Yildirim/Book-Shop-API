using BookShopAPI.Application.Repositories.Abstracts;
using BookShopAPI.Domain.Entities;

namespace BookShopAPI.Application.Repositories.CommentRatingRepositories
{
    public interface ICommentRatingWriteRepository : IWriteRepository<CommentRating>
    {
    }
}