using BookShopAPI.Application.Repositories.CommentRatingRepositories;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Persistence.EntityFramework.Contexts;
using BookShopAPI.Persistence.EntityFramework.Repositories.Abstracts;

namespace BookShopAPI.Persistence.EntityFramework.Repositories.CommendRatingRepositories
{
    public sealed class CommentRatingWriteRepository : BaseWriteRepository<CommentRating>, ICommentRatingWriteRepository
    {
        public CommentRatingWriteRepository(BookShopDbContext context) : base(context)
        {
        }
    }
}