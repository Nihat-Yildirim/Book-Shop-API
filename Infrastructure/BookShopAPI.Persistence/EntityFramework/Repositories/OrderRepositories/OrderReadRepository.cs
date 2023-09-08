using BookShopAPI.Application.Repositories.OrderRepositories;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Persistence.EntityFramework.Contexts;
using BookShopAPI.Persistence.EntityFramework.Repositories.Abstracts;

namespace BookShopAPI.Persistence.EntityFramework.Repositories.OrderRepositories
{
    public class OrderReadRepository : BaseReadRepository<Order>, IOrderReadRepository
    {
        public OrderReadRepository(BookShopDbContext context) : base(context)
        {
        }
    }
}