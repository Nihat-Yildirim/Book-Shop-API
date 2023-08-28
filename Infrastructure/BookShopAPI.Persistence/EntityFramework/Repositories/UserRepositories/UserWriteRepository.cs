using BookShopAPI.Application.Repositories.UserRepositories;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Persistence.EntityFramework.Contexts;
using BookShopAPI.Persistence.EntityFramework.Repositories.Abstracts;

namespace BookShopAPI.Persistence.EntityFramework.Repositories.UserRepositories
{
    public sealed class UserWriteRepository : BaseWriteRepository<User>, IUserWriteRepository
    {
        public UserWriteRepository(BookShopDbContext context) : base(context)
        {
        }
    }
}