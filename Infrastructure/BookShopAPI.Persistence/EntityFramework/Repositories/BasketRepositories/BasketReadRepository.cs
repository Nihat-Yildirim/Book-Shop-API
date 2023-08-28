using BookShopAPI.Application.Repositories.BasketRepositories;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Persistence.EntityFramework.Contexts;
using BookShopAPI.Persistence.EntityFramework.Repositories.Abstracts;

namespace BookShopAPI.Persistence.EntityFramework.Repositories.BasketRepositories
{
    public sealed class BasketReadRepository : BaseReadRepository<Basket>, IBasketReadRepository
    {
        public BasketReadRepository(BookShopDbContext context) : base(context)
        {
        }
    }
}