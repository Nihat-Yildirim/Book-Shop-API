using BookShopAPI.Application.Repositories.Abstracts;
using BookShopAPI.Domain.Entities;

namespace BookShopAPI.Application.Repositories.PhoneNumberRepositories
{
    public interface IPhoneNumberWriteRepository : IWriteRepository<PhoneNumberEntity>
    {
    }
}