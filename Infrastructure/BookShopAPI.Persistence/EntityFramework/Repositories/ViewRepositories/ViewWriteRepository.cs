using BookShopAPI.Application.Repositories.ViewRepositories;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Persistence.EntityFramework.Contexts;
using BookShopAPI.Persistence.EntityFramework.Repositories.Abstracts;

namespace BookShopAPI.Persistence.EntityFramework.Repositories.ViewRepositories
{
    public class ViewWriteRepository : BaseWriteRepository<View>, IViewWriteRepository
    {
        public ViewWriteRepository(BookShopDbContext context) : base(context)
        {
        }
    }
}