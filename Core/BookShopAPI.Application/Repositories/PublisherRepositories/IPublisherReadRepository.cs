using BookShopAPI.Application.Repositories.Abstracts;
using BookShopAPI.Domain.Entities;
using System.Linq.Expressions;

namespace BookShopAPI.Application.Repositories.PublisherRepositories
{
    public interface IPublisherReadRepository : IReadRepository<Publisher>
    {
        Task<Publisher> GetPublisherByPublisherLogoFileAsync(Expression<Func<Publisher, bool>> filter,bool tracing = true);
    }
}