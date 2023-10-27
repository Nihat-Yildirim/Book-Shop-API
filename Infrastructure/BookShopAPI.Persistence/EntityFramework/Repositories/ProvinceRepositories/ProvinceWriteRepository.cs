using BookShopAPI.Application.Repositories.ProvinceRepositories;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Persistence.EntityFramework.Contexts;
using BookShopAPI.Persistence.EntityFramework.Repositories.Abstracts;

namespace BookShopAPI.Persistence.EntityFramework.Repositories.ProvinceRepositories
{
    public class ProvinceWriteRepository : BaseWriteRepository<Province>, IProvinceWriteRepository
    {
        public ProvinceWriteRepository(BookShopDbContext context) : base(context)
        {
        }
    }
}