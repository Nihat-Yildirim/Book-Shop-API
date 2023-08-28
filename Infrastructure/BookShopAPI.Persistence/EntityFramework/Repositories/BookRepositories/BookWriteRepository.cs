using BookShopAPI.Application.Repositories.BookRepositories;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Persistence.EntityFramework.Contexts;
using BookShopAPI.Persistence.EntityFramework.Repositories.Abstracts;

namespace BookShopAPI.Persistence.EntityFramework.Repositories.BookRepositories
{
    public sealed class BookWriteRepository : BaseWriteRepository<Book>, IBookWriteRepository
    {
        public BookWriteRepository(BookShopDbContext context) : base(context)
        {
        }
    }
}