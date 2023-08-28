using BookShopAPI.Application.Repositories.UserRepositories;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Persistence.EntityFramework.Contexts;
using BookShopAPI.Persistence.EntityFramework.Repositories.Abstracts;

namespace BookShopAPI.Persistence.EntityFramework.Repositories.UserRepositories
{
    public sealed class UserReadRepository : BaseReadRepository<User>, IUserReadRepository
    {
        public UserReadRepository(BookShopDbContext context) : base(context)
        {
        }
    }
}