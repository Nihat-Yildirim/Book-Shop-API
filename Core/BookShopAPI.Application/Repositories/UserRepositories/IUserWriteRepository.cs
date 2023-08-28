using BookShopAPI.Application.Repositories.Abstracts;
using BookShopAPI.Domain.Entities;

namespace BookShopAPI.Application.Repositories.UserRepositories
{
    public interface IUserWriteRepository : IWriteRepository<User>
    {
    }
}