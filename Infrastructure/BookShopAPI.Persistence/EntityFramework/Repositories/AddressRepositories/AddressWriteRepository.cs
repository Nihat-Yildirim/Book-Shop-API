using BookShopAPI.Application.Repositories.AddressRepositories;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Persistence.EntityFramework.Contexts;
using BookShopAPI.Persistence.EntityFramework.Repositories.Abstracts;

namespace BookShopAPI.Persistence.EntityFramework.Repositories.AddressRepositories
{
    public sealed class AddressWriteRepository : BaseWriteRepository<Address> , IAddressWriteRepository
    {
        public AddressWriteRepository(BookShopDbContext context) : base(context)
        {
        }
    }
}