using BookShopAPI.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;

namespace BookShopAPI.Application.Repositories.Abstracts
{
    public interface IRepository<TEntity> where TEntity : BaseEntity , new()
    {
        public DbSet<TEntity> Table { get; }
    }
}