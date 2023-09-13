using BookShopAPI.Application.Repositories.OrderRepositories;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Persistence.EntityFramework.Contexts;
using BookShopAPI.Persistence.EntityFramework.Repositories.Abstracts;

namespace BookShopAPI.Persistence.EntityFramework.Repositories.OrderRepositories
{
    public sealed class OrderWriteRepository : BaseWriteRepository<Order>, IOrderWriteRepository
    {
        public OrderWriteRepository(BookShopDbContext context) : base(context)
        {
        }
    }
}