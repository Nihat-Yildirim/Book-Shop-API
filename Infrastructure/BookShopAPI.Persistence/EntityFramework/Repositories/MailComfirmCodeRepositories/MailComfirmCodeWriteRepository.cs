using BookShopAPI.Application.Repositories.MailComfirmCodeRepositories;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Persistence.EntityFramework.Contexts;
using BookShopAPI.Persistence.EntityFramework.Repositories.Abstracts;

namespace BookShopAPI.Persistence.EntityFramework.Repositories.MailComfirmCodeRepositories
{
    public sealed class MailComfirmCodeWriteRepository : BaseWriteRepository<MailComfirmCode>, IMailComfirmCodeWriteRepository
    {
        public MailComfirmCodeWriteRepository(BookShopDbContext context) : base(context)
        {
        }
    }
}