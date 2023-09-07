using BookShopAPI.Application.Repositories.BookPictureRepositories;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Persistence.EntityFramework.Contexts;
using BookShopAPI.Persistence.EntityFramework.Repositories.Abstracts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BookShopAPI.Persistence.EntityFramework.Repositories.BookPictureRepositories
{
    public sealed class BookPictureReadRepository : BaseReadRepository<BookPicture>, IBookPictureReadRepository
    {
        public BookPictureReadRepository(BookShopDbContext context) : base(context)
        {
        }

        public async Task<List<BookPicture>> GetBookPicturesWithPictureFileAsync(Expression<Func<BookPicture, bool>> filter, bool tracing = true)
        {
            var query = Table.Include(x => x.File);

            if (!tracing)
                query.AsNoTracking();

            return await query.Where(filter).ToListAsync();
        }
    }
}