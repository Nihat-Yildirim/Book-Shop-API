using BookShopAPI.Application.Repositories.BookSearchDataRepositories;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Persistence.EntityFramework.Contexts;
using BookShopAPI.Persistence.EntityFramework.Repositories.Abstracts;

namespace BookShopAPI.Persistence.EntityFramework.Repositories.BookSearchDataRepositories
{
    public class BookSearchDataReadRepository : BaseReadRepository<BookSearchData>, IBookSearchDataReadRepository
    {
        public BookSearchDataReadRepository(BookShopDbContext context) : base(context)
        {
        }
    }
}