using BookShopAPI.Application.Repositories.FileRepositories;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Persistence.EntityFramework.Contexts;
using BookShopAPI.Persistence.EntityFramework.Repositories.Abstracts;

namespace BookShopAPI.Persistence.EntityFramework.Repositories.FileRepositories
{
    public sealed class FileWriteRepository : BaseWriteRepository<FileEntity>, IFileWriteRepository
    {
        public FileWriteRepository(BookShopDbContext context) : base(context)
        {
        }
    }
}