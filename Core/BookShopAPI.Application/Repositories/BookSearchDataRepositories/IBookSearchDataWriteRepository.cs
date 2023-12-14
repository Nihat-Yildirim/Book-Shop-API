using BookShopAPI.Application.Repositories.Abstracts;
using BookShopAPI.Domain.Entities;

namespace BookShopAPI.Application.Repositories.BookSearchDataRepositories
{
    public interface IBookSearchDataWriteRepository : IWriteRepository<BookSearchData>
    {
    }
}