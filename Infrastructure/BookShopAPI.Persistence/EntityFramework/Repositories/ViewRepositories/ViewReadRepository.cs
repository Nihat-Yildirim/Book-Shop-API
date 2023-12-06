using BookShopAPI.Application.Repositories.ViewRepositories;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Persistence.EntityFramework.Contexts;
using BookShopAPI.Persistence.EntityFramework.Repositories.Abstracts;

namespace BookShopAPI.Persistence.EntityFramework.Repositories.ViewRepositories
{
    public class ViewReadRepository : BaseReadRepository<View>, IViewReadRepository
    {
        public ViewReadRepository(BookShopDbContext context) : base(context)
        {
        }
    }
}