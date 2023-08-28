using BookShopAPI.Application.Repositories.Abstracts;
using BookShopAPI.Domain.Entities;

namespace BookShopAPI.Application.Repositories.UserClaimRepositories
{
    public interface IUserClaimWriteRepository : IWriteRepository<UserClaim>
    {
    }
}