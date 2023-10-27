using BookShopAPI.Application.Repositories.DistrictRepository;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Persistence.EntityFramework.Contexts;
using BookShopAPI.Persistence.EntityFramework.Repositories.Abstracts;

namespace BookShopAPI.Persistence.EntityFramework.Repositories.DistrictRepositories
{
    public class DistrictReadRepository : BaseReadRepository<District>, IDistrictReadRepository
    {
        public DistrictReadRepository(BookShopDbContext context) : base(context)
        {
        }
    }
}