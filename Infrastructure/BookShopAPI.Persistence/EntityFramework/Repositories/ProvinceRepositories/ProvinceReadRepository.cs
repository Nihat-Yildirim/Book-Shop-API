using BookShopAPI.Application.Repositories.ProvinceRepositories;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Persistence.EntityFramework.Contexts;
using BookShopAPI.Persistence.EntityFramework.Repositories.Abstracts;

namespace BookShopAPI.Persistence.EntityFramework.Repositories.ProvinceRepositories
{
    public class ProvinceReadRepository : BaseReadRepository<Province>, IProvinceReadRepository
    {
        public ProvinceReadRepository(BookShopDbContext context) : base(context)
        {
        }
    }
}