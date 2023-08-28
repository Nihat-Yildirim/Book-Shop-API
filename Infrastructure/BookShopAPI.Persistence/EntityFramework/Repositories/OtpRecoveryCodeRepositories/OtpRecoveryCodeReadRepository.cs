using BookShopAPI.Application.Repositories.OtpRecoveryCodeRepositories;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Persistence.EntityFramework.Contexts;
using BookShopAPI.Persistence.EntityFramework.Repositories.Abstracts;

namespace BookShopAPI.Persistence.EntityFramework.Repositories.OtpRecoveryCodeRepositories
{
    public sealed class OtpRecoveryCodeReadRepository : BaseReadRepository<OtpRecoveryCode>, IOtpRecoveryCodeReadRepository
    {
        public OtpRecoveryCodeReadRepository(BookShopDbContext context) : base(context)
        {
        }
    }
}