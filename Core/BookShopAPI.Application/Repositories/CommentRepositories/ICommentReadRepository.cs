using BookShopAPI.Application.DTOs.CommentDTOs;
using BookShopAPI.Application.Repositories.Abstracts;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Domain.RequestParameters;
using System.Linq.Expressions;

namespace BookShopAPI.Application.Repositories.CommentRepositories
{
    public interface ICommentReadRepository : IReadRepository<CommentEntity>
    {
        Task<List<CommentDto>> GetCommentDtosAsync(Pagination pagination, int userId,Expression<Func<CommentEntity, bool>> filter = null);
        Task<List<CommentForAdminDto>> GetCommentForAdminDtosAsync(Pagination pagination,Expression<Func<CommentEntity, bool>> filter = null);
    }
}