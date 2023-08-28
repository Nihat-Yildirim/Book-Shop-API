using BookShopAPI.Application.Repositories.Abstracts;
using BookShopAPI.Domain.Entities;

namespace BookShopAPI.Application.Repositories.ClaimRepositories
{
    public interface IClaimWriteRepository : IWriteRepository<Claim>
    {
    }
}