using BookShopAPI.Application.Repositories.Abstracts;
using BookShopAPI.Domain.Entities;

namespace BookShopAPI.Application.Repositories.AddressRepositories
{
    public interface IAddressWriteRepository : IWriteRepository<Address>
    {
    }
}