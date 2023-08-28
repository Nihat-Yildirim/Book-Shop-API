using BookShopAPI.Application.Repositories.OtpRecoveryCodeRepositories;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Persistence.EntityFramework.Contexts;
using BookShopAPI.Persistence.EntityFramework.Repositories.Abstracts;

namespace BookShopAPI.Persistence.EntityFramework.Repositories.OtpRecoveryCodeRepositories
{
    public sealed class OtpRecoveryCodeWriteRepository : BaseWriteRepository<OtpRecoveryCode>, IOtpRecoveryCodeWriteRepository
    {
        public OtpRecoveryCodeWriteRepository(BookShopDbContext context) : base(context)
        {
        }
    }
}