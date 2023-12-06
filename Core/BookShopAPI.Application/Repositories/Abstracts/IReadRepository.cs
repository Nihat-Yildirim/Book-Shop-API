using BookShopAPI.Domain.Entities.Common;
using System.Linq.Expressions;

namespace BookShopAPI.Application.Repositories.Abstracts
{
    public interface IReadRepository<TEntity> : IRepository<TEntity>
        where TEntity : BaseEntity, new()
    {
        IQueryable<TEntity> GetWhere(Expression<Func<TEntity, bool>> filter, bool tracing = true);
        IQueryable<TEntity> GetAll(bool tracing = true);
        Task<TEntity> GetSingleAsync(Expression<Func<TEntity, bool>> filter, bool tracing = true);
        Task<TEntity> GetByIdAsync(int id, bool tracing = true);
        Task<bool> AnyAsync(Expression<Func<TEntity, bool>> filter);
    }
}