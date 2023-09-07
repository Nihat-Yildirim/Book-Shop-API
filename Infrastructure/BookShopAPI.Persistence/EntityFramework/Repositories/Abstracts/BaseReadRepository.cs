using BookShopAPI.Application.Repositories.Abstracts;
using BookShopAPI.Domain.Entities.Common;
using BookShopAPI.Persistence.EntityFramework.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BookShopAPI.Persistence.EntityFramework.Repositories.Abstracts
{
    public abstract class BaseReadRepository<TEntity> : IReadRepository<TEntity>
        where TEntity : BaseEntity, new()
    {
        public DbSet<TEntity> Table { get; }
        public readonly BookShopDbContext _context;
        public BaseReadRepository(BookShopDbContext context)
        {
            _context = context;
            Table = _context.Set<TEntity>();
        }

        public IQueryable<TEntity> GetAll(bool tracing = true)
        {
            var query = Table;

            if (!tracing)
                return query.AsNoTracking();

            return query;
        }

        public IQueryable<TEntity> GetWhere(Expression<Func<TEntity, bool>> filter, bool tracing = true)
        {
            var query = Table.Where(filter).AsQueryable();

            if(!tracing)
                return query.AsNoTracking();

            return query;
        }

        public async Task<TEntity> GetByIdAsync(int id, bool tracing = true)
        {
            var query = Table.AsQueryable();

            if(!tracing)
                query = query.AsNoTracking();

            return await query.SingleOrDefaultAsync(x => x.Id == id);
        }

        public async Task<TEntity> GetSingleAsync(Expression<Func<TEntity, bool>> filter, bool tracing = true)
        {
            var query = Table.AsQueryable();

            if (!tracing)
                query = query.AsNoTracking();

            return await query.SingleOrDefaultAsync(filter);
        }

        public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>> filter)
        {
            return await Table.AnyAsync(filter);
        }
    }
}