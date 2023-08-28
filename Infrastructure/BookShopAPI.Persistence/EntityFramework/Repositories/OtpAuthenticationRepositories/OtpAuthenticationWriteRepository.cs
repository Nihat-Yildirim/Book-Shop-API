using BookShopAPI.Application.Repositories.OtpAuthenticationRepositories;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Persistence.EntityFramework.Contexts;
using BookShopAPI.Persistence.EntityFramework.Repositories.Abstracts;

namespace BookShopAPI.Persistence.EntityFramework.Repositories.OtpAuthenticationRepositories
{
    public sealed class OtpAuthenticationWriteRepository : BaseWriteRepository<OtpAuthentication>, IOtpAuthenticationWriteRepository
    {
        public OtpAuthenticationWriteRepository(BookShopDbContext context) : base(context)
        {
        }
    }
}