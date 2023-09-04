using BookShopAPI.Application.Repositories.AuthorRepositories;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Persistence.EntityFramework.Contexts;
using BookShopAPI.Persistence.EntityFramework.Repositories.Abstracts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BookShopAPI.Persistence.EntityFramework.Repositories.AuthorRepositories
{
    public sealed class AuthorReadRepository : BaseReadRepository<Author>, IAuthorReadRepository
    {
        public AuthorReadRepository(BookShopDbContext context) : base(context)
        {
        }

        public async Task<Author> GetAuthorByAuthorPictureFileAsync(Expression<Func<Author, bool>> filter, bool tracing = true)
        {
            var query = Table.Include(x => x.File);

            if (!tracing)
                query.AsNoTracking();

            return await query.SingleOrDefaultAsync(filter);
        }
    }
}