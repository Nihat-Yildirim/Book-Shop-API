using BookShopAPI.Application.Repositories.Abstracts;
using BookShopAPI.Domain.Entities;

namespace BookShopAPI.Application.Repositories.MailComfirmCodeRepositories
{
    public interface IMailComfirmCodeReadRepository : IReadRepository<MailComfirmCode>
    {
    }
}