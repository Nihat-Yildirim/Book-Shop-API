using BookShopAPI.Application.Repositories.CommentRepositories;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Persistence.EntityFramework.Contexts;
using BookShopAPI.Persistence.EntityFramework.Repositories.Abstracts;

namespace BookShopAPI.Persistence.EntityFramework.Repositories.CommendRepositories
{
    public sealed class CommentWriteRepository : BaseWriteRepository<CommentEntity>, ICommentWriteRepository
    {
        public CommentWriteRepository(BookShopDbContext context) : base(context)
        {
        }
    }
}