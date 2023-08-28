using BookShopAPI.Application.Repositories.Abstracts;
using BookShopAPI.Domain.Entities;

namespace BookShopAPI.Application.Repositories.BasketRepositories
{
    public interface IBasketWriteRepository : IWriteRepository<Basket>
    {
    }
}