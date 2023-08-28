using BookShopAPI.Application.Repositories.BasketItemRepositories;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Persistence.EntityFramework.Contexts;
using BookShopAPI.Persistence.EntityFramework.Repositories.Abstracts;

namespace BookShopAPI.Persistence.EntityFramework.Repositories.BasketItemRepositories
{
    public sealed class BasketItemReadRepository : BaseReadRepository<BasketItem>, IBasketItemReadRepository
    {
        public BasketItemReadRepository(BookShopDbContext context) : base(context)
        {
        }
    }
}