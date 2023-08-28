using BookShopAPI.Application.Repositories.BasketRepositories;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Persistence.EntityFramework.Contexts;
using BookShopAPI.Persistence.EntityFramework.Repositories.Abstracts;

namespace BookShopAPI.Persistence.EntityFramework.Repositories.BasketRepositories
{
    public sealed class BasketWriteRepository : BaseWriteRepository<Basket>, IBasketWriteRepository
    {
        public BasketWriteRepository(BookShopDbContext context) : base(context)
        {
        }
    }
}