using BookShopAPI.Application.Repositories.PublisherSearchDataRepositories;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Persistence.EntityFramework.Contexts;
using BookShopAPI.Persistence.EntityFramework.Repositories.Abstracts;

namespace BookShopAPI.Persistence.EntityFramework.Repositories.PublisherSearchDataRepositories
{
    public class PublisherSearchDataReadRepository : BaseReadRepository<PublisherSearchData>, IPublisherSearchDataReadRepository
    {
        public PublisherSearchDataReadRepository(BookShopDbContext context) : base(context)
        {
        }
    }
}