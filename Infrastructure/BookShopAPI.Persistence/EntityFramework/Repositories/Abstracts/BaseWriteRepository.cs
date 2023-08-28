using BookShopAPI.Application.Repositories.Abstracts;
using BookShopAPI.Domain.Entities.Common;
using BookShopAPI.Persistence.EntityFramework.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace BookShopAPI.Persistence.EntityFramework.Repositories.Abstracts
{
    public abstract class BaseWriteRepository<TEntity> : IWriteRepository<TEntity>
        where TEntity : BaseEntity, new()
    {
        public DbSet<TEntity> Table { get; }
        private readonly BookShopDbContext _context;

        public BaseWriteRepository(BookShopDbContext context)
        {
            _context = context;
            Table = _context.Set<TEntity>();
        }

        public async Task<bool> AddAsync(TEntity entity)
        {
            EntityEntry<TEntity> entityEntry = await Table.AddAsync(entity);

            return entityEntry.State == EntityState.Added;
        }

        public async Task<bool> AddRangeAsync(List<TEntity> entities)
        {
            await Table.AddRangeAsync(entities);    

            return true;
        }

        public bool Remove(TEntity entity)
        {
            EntityEntry<TEntity> entityEntry = Table.Remove(entity);

            return entityEntry.State == EntityState.Deleted;
        }

        public async Task<bool> RemoveByIdAsync(int id)
        {
            var deletedEntity = await Table.FindAsync(id);

            return Remove(deletedEntity);
        }

        public bool RemoveRange(List<TEntity> entities)
        {
            Table.RemoveRange(entities);

            return true;
        }

        public bool Update(TEntity entity)
        {
            EntityEntry<TEntity> entityEntry = Table.Update(entity);    

            return entityEntry.State == EntityState.Modified;
        }

        public bool UpdateRange(List<TEntity> entities)
        {
            Table.UpdateRange(entities);

            return true;
        }
    }
}