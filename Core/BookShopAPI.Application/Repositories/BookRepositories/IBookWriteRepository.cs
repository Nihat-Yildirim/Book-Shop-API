using BookShopAPI.Application.Repositories.Abstracts;
using BookShopAPI.Domain.Entities;

namespace BookShopAPI.Application.Repositories.BookRepositories
{
    public interface IBookWriteRepository : IWriteRepository<Book>
    {
    }
}