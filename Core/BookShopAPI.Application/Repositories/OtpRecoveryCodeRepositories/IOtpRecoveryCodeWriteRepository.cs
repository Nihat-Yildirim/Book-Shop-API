using BookShopAPI.Application.Repositories.Abstracts;
using BookShopAPI.Domain.Entities;

namespace BookShopAPI.Application.Repositories.OtpRecoveryCodeRepositories
{
    public interface IOtpRecoveryCodeWriteRepository : IWriteRepository<OtpRecoveryCode>
    {
    }
}