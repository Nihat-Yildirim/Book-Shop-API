using BookShopAPI.Application.Repositories.PublisherRepositories;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Persistence.EntityFramework.Contexts;
using BookShopAPI.Persistence.EntityFramework.Repositories.Abstracts;

namespace BookShopAPI.Persistence.EntityFramework.Repositories.PublisherRepositories
{
    public sealed class PublisherReadRepository : BaseReadRepository<Publisher>, IPublisherReadRepository
    {
        public PublisherReadRepository(BookShopDbContext context) : base(context)
        {
        }
    }
}