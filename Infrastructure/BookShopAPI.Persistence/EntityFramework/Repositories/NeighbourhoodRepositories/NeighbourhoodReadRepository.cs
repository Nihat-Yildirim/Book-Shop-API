using BookShopAPI.Application.Repositories.NeighbourhoodRepositories;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Persistence.EntityFramework.Contexts;
using BookShopAPI.Persistence.EntityFramework.Repositories.Abstracts;

namespace BookShopAPI.Persistence.EntityFramework.Repositories.NeighbourhoodRepositories
{
    public class NeighbourhoodReadRepository : BaseReadRepository<Neighbourhood>, INeighbourhoodReadRepository
    {
        public NeighbourhoodReadRepository(BookShopDbContext context) : base(context)
        {
        }
    }
}