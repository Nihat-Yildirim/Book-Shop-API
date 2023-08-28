using BookShopAPI.Application.Repositories.BasketItemRepositories;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Persistence.EntityFramework.Contexts;
using BookShopAPI.Persistence.EntityFramework.Repositories.Abstracts;

namespace BookShopAPI.Persistence.EntityFramework.Repositories.BasketItemRepositories
{
    public sealed class BasketItemWriteRepository : BaseWriteRepository<BasketItem>, IBasketItemWriteRepository
    {
        public BasketItemWriteRepository(BookShopDbContext context) : base(context)
        {
        }
    }
}