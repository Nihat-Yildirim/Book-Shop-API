using BookShopAPI.Application.Repositories.PhoneNumberRepositories;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Persistence.EntityFramework.Contexts;
using BookShopAPI.Persistence.EntityFramework.Repositories.Abstracts;

namespace BookShopAPI.Persistence.EntityFramework.Repositories.PhoneNumberRepositories
{
    public sealed class PhoneNumberReadRepository : BaseReadRepository<PhoneNumberEntity>, IPhoneNumberReadRepository
    {
        public PhoneNumberReadRepository(BookShopDbContext context) : base(context)
        {
        }
    }
}