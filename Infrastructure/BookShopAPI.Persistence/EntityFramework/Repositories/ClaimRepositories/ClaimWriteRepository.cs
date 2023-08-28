using BookShopAPI.Application.Repositories.ClaimRepositories;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Persistence.EntityFramework.Contexts;
using BookShopAPI.Persistence.EntityFramework.Repositories.Abstracts;

namespace BookShopAPI.Persistence.EntityFramework.Repositories.ClaimRepositories
{
    public sealed class ClaimWriteRepository : BaseWriteRepository<Claim>, IClaimWriteRepository
    {
        public ClaimWriteRepository(BookShopDbContext context) : base(context)
        {
        }
    }
}