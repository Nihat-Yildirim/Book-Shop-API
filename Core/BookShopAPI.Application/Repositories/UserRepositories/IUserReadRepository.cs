using BookShopAPI.Application.Repositories.Abstracts;
using BookShopAPI.Domain.Entities;
using System.Linq.Expressions;

namespace BookShopAPI.Application.Repositories.UserRepositories
{
    public interface IUserReadRepository : IReadRepository<User>
    {
        Task<User> GetUserWithMailComfirmCode(Expression<Func<User, bool>> filter , bool tracing = true);
        Task<User> GetUserWithUserAvatarFile(Expression<Func<User, bool>> filter, bool tracing = true);
        Task<User> GetUserWithAddress(Expression<Func<User, bool>> filter, bool tracing = true);
        Task<User> GetUserWithPhoneNumber(Expression<Func<User, bool>> filter, bool tracing = true);
    }
}