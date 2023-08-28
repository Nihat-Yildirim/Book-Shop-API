using BookShopAPI.Application.Repositories.AddressRepositories;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Persistence.EntityFramework.Contexts;
using BookShopAPI.Persistence.EntityFramework.Repositories.Abstracts;

namespace BookShopAPI.Persistence.EntityFramework.Repositories.AddressRepositories
{
    public sealed class AddressReadRepository : BaseReadRepository<Address>, IAddressReadRepository
    {
        public AddressReadRepository(BookShopDbContext context) : base(context)
        {
        }
    }
}