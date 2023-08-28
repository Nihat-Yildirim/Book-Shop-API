using BookShopAPI.Application.Repositories.ClaimRepositories;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Persistence.EntityFramework.Contexts;
using BookShopAPI.Persistence.EntityFramework.Repositories.Abstracts;

namespace BookShopAPI.Persistence.EntityFramework.Repositories.ClaimRepositories
{
    public sealed class ClaimReadRepository : BaseReadRepository<Claim>, IClaimReadRepository
    {
        public ClaimReadRepository(BookShopDbContext context) : base(context)
        {
        }
    }
}