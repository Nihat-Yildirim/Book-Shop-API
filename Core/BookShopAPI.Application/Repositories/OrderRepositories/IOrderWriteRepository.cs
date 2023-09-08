using BookShopAPI.Application.Repositories.Abstracts;
using BookShopAPI.Domain.Entities;

namespace BookShopAPI.Application.Repositories.OrderRepositories
{
    public interface IOrderWriteRepository : IWriteRepository<Order>
    {
    }
}