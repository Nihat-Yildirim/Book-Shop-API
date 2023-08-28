using BookShopAPI.Application.Repositories.Abstracts;
using BookShopAPI.Domain.Entities;

namespace BookShopAPI.Application.Repositories.MailAuthenticationRepositories
{
    public interface IMailAuthenticationWriteRepository : IWriteRepository<MailAuthentication>
    {
    }
}