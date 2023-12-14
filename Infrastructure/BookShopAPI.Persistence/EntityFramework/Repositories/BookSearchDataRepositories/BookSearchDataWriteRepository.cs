using BookShopAPI.Application.Repositories.BookSearchDataRepositories;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Persistence.EntityFramework.Contexts;
using BookShopAPI.Persistence.EntityFramework.Repositories.Abstracts;

namespace BookShopAPI.Persistence.EntityFramework.Repositories.BookSearchDataRepositories
{
    public class BookSearchDataWriteRepository : BaseWriteRepository<BookSearchData>, IBookSearchDataWriteRepository
    {
        public BookSearchDataWriteRepository(BookShopDbContext context) : base(context)
        {
        }
    }
}