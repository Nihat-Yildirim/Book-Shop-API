using BookShopAPI.Application.Repositories.Abstracts;
using BookShopAPI.Domain.Entities;

namespace BookShopAPI.Application.Repositories.OrderRepositories
{
    public interface IOrderReadRepository : IReadRepository<Order>
    {
    }
}