using BookShopAPI.Application.Repositories.PhoneNumberRepositories;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Persistence.EntityFramework.Contexts;
using BookShopAPI.Persistence.EntityFramework.Repositories.Abstracts;

namespace BookShopAPI.Persistence.EntityFramework.Repositories.PhoneNumberRepositories
{
    public sealed class PhoneNumberWriteRepository : BaseWriteRepository<PhoneNumberEntity>, IPhoneNumberWriteRepository
    {
        public PhoneNumberWriteRepository(BookShopDbContext context) : base(context)
        {
        }
    }
}