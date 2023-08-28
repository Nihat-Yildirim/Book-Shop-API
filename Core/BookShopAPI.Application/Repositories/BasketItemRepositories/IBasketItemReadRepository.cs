using BookShopAPI.Application.Repositories.Abstracts;
using BookShopAPI.Domain.Entities;

namespace BookShopAPI.Application.Repositories.BasketItemRepositories
{
    public interface IBasketItemReadRepository : IReadRepository<BasketItem>
    {
    }
}