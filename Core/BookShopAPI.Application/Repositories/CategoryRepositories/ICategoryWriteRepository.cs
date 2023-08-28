using BookShopAPI.Application.Repositories.Abstracts;
using BookShopAPI.Domain.Entities;

namespace BookShopAPI.Application.Repositories.CategoryRepositories
{
    public interface ICategoryWriteRepository : IWriteRepository<Category>
    {
    }
}