using BookShopAPI.Application.Repositories.Abstracts;
using BookShopAPI.Domain.Entities;

namespace BookShopAPI.Application.Repositories.PublisherRepositories
{
    public interface IPublisherWriteRepository : IWriteRepository<Publisher>
    {
    }
}