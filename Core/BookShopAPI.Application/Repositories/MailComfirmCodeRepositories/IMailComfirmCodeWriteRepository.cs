using BookShopAPI.Application.Repositories.Abstracts;
using BookShopAPI.Domain.Entities;

namespace BookShopAPI.Application.Repositories.MailComfirmCodeRepositories
{
    public interface IMailComfirmCodeWriteRepository : IWriteRepository<MailComfirmCode>
    {
    }
}