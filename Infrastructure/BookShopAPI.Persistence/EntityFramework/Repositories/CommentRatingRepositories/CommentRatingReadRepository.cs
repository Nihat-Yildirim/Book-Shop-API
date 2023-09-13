using BookShopAPI.Application.Repositories.CommentRatingRepositories;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Persistence.EntityFramework.Contexts;
using BookShopAPI.Persistence.EntityFramework.Repositories.Abstracts;

namespace BookShopAPI.Persistence.EntityFramework.Repositories.CommendRatingRepositories
{
    public class CommentRatingReadRepository : BaseReadRepository<CommentRating>, ICommentRatingReadRepository
    {
        public CommentRatingReadRepository(BookShopDbContext context) : base(context)
        {
        }
    }
}