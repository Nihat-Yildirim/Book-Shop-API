using BookShopAPI.Application.Repositories.Abstracts;
using BookShopAPI.Domain.Entities;

namespace BookShopAPI.Application.Repositories.ViewRepositories
{
    public interface IViewWriteRepository : IWriteRepository<View>
    {
    }
}