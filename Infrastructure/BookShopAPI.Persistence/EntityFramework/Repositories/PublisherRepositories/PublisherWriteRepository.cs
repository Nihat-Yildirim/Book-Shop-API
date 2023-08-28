using BookShopAPI.Application.Repositories.PublisherRepositories;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Persistence.EntityFramework.Contexts;
using BookShopAPI.Persistence.EntityFramework.Repositories.Abstracts;

namespace BookShopAPI.Persistence.EntityFramework.Repositories.PublisherRepositories
{
    public sealed class PublisherWriteRepository : BaseWriteRepository<Publisher>, IPublisherWriteRepository
    {
        public PublisherWriteRepository(BookShopDbContext context) : base(context)
        {
        }
    }
}