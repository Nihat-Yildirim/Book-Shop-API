using BookShopAPI.Application.Repositories.UserRepositories;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Persistence.EntityFramework.Contexts;
using BookShopAPI.Persistence.EntityFramework.Repositories.Abstracts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BookShopAPI.Persistence.EntityFramework.Repositories.UserRepositories
{
    public sealed class UserReadRepository : BaseReadRepository<User>, IUserReadRepository
    {
        public UserReadRepository(BookShopDbContext context) : base(context)
        {
        }

        public async Task<User> GetUserWithMailComfirmCode(Expression<Func<User, bool>> filter, bool tracing = true)
        {
            var query = Table.Include(x => x.MailComfirmCode);

            if (!tracing)
                query.AsNoTracking();

            return await query.SingleOrDefaultAsync(filter);
        }

        public async Task<User> GetUserWithUserAvatarFile(Expression<Func<User, bool>> filter, bool tracing = true)
        {
            var query = Table.Include(x => x.File);

            if (!tracing)
                query.AsNoTracking();

            return await query.SingleOrDefaultAsync(filter);
        }
    }
}