using BookShopAPI.Application.Repositories.Abstracts;
using BookShopAPI.Domain.Entities;

namespace BookShopAPI.Application.Repositories.FileRepositories
{
    public interface IFileReadRepository : IReadRepository<FileEntity>
    {
    }
}