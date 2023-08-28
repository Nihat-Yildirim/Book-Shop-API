using BookShopAPI.Application.Repositories.BookRepositories;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Persistence.EntityFramework.Contexts;
using BookShopAPI.Persistence.EntityFramework.Repositories.Abstracts;

namespace BookShopAPI.Persistence.EntityFramework.Repositories.BookRepositories
{
    public sealed class BookReadRepository : BaseReadRepository<Book>, IBookReadRepository
    {
        public BookReadRepository(BookShopDbContext context) : base(context)
        {
        }
    }
}