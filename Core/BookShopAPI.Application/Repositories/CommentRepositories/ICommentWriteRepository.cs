using BookShopAPI.Application.Repositories.Abstracts;
using BookShopAPI.Domain.Entities;

namespace BookShopAPI.Application.Repositories.CommentRepositories
{
    public interface ICommentWriteRepository : IWriteRepository<CommentEntity>
    {
    }
}