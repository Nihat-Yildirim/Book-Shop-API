using BookShopAPI.Application.Repositories.PublisherRepositories;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Persistence.EntityFramework.Contexts;
using BookShopAPI.Persistence.EntityFramework.Repositories.Abstracts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BookShopAPI.Persistence.EntityFramework.Repositories.PublisherRepositories
{
    public sealed class PublisherReadRepository : BaseReadRepository<Publisher>, IPublisherReadRepository
    {
        public PublisherReadRepository(BookShopDbContext context) : base(context)
        {
        }

        public async Task<Publisher> GetPublisherByPublisherLogoFileAsync(Expression<Func<Publisher, bool>> filter, bool tracing = true)
        {
            var query = Table.Include(x => x.File);

            if (!tracing)
                query.AsNoTracking();

            return await query.SingleOrDefaultAsync(filter);
        }
    }
}