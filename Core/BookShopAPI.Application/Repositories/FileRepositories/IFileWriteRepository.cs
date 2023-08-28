using BookShopAPI.Application.Repositories.Abstracts;
using BookShopAPI.Domain.Entities;

namespace BookShopAPI.Application.Repositories.FileRepositories
{
    public interface IFileWriteRepository : IWriteRepository<FileEntity>
    {
    }
}