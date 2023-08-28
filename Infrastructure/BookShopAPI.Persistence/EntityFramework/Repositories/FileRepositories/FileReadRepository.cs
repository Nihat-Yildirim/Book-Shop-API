using BookShopAPI.Application.Repositories.FileRepositories;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Persistence.EntityFramework.Contexts;
using BookShopAPI.Persistence.EntityFramework.Repositories.Abstracts;

namespace BookShopAPI.Persistence.EntityFramework.Repositories.FileRepositories
{
    public sealed class FileReadRepository : BaseReadRepository<FileEntity>, IFileReadRepository
    {
        public FileReadRepository(BookShopDbContext context) : base(context)
        {
        }
    }
}