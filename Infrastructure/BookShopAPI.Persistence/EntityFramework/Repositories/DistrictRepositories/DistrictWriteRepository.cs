using BookShopAPI.Application.Repositories.DistrictRepository;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Persistence.EntityFramework.Contexts;
using BookShopAPI.Persistence.EntityFramework.Repositories.Abstracts;

namespace BookShopAPI.Persistence.EntityFramework.Repositories.DistrictRepositories
{
    public class DistrictWriteRepository : BaseWriteRepository<District>, IDistrictWriteRepository
    {
        public DistrictWriteRepository(BookShopDbContext context) : base(context)
        {
        }
    }
}