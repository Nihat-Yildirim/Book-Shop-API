using BookShopAPI.Application.Repositories.UserClaimRepositories;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Persistence.EntityFramework.Contexts;
using BookShopAPI.Persistence.EntityFramework.Repositories.Abstracts;

namespace BookShopAPI.Persistence.EntityFramework.Repositories.UserClaimRepositories
{
    public sealed class UserClaimWriteRepository : BaseWriteRepository<UserClaim>, IUserClaimWriteRepository
    {
        public UserClaimWriteRepository(BookShopDbContext context) : base(context)
        {
        }
    }
}