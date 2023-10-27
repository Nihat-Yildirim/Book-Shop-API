using BookShopAPI.Application.Repositories.NeighbourhoodRepositories;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Persistence.EntityFramework.Contexts;
using BookShopAPI.Persistence.EntityFramework.Repositories.Abstracts;

namespace BookShopAPI.Persistence.EntityFramework.Repositories.NeighbourhoodRepositories
{
    public class NeighbourhoodWriteRepository : BaseWriteRepository<Neighbourhood>, INeighbourhoodWriteRepository
    {
        public NeighbourhoodWriteRepository(BookShopDbContext context) : base(context)
        {
        }
    }
}