using BookShopAPI.Application.Repositories.Abstracts;
using BookShopAPI.Domain.Entities;

namespace BookShopAPI.Application.Repositories.OtpAuthenticationRepositories
{
    public interface IOtpAuthenticationWriteRepository : IWriteRepository<OtpAuthentication>
    {
    }
}