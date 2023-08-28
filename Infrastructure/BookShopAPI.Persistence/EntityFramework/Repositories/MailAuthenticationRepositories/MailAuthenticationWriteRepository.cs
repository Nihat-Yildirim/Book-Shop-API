using BookShopAPI.Application.Repositories.MailAuthenticationRepositories;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Persistence.EntityFramework.Contexts;
using BookShopAPI.Persistence.EntityFramework.Repositories.Abstracts;

namespace BookShopAPI.Persistence.EntityFramework.Repositories.MailAuthenticationRepositories
{
    public sealed class MailAuthenticationWriteRepository : BaseWriteRepository<MailAuthentication>, IMailAuthenticationWriteRepository
    {
        public MailAuthenticationWriteRepository(BookShopDbContext context) : base(context)
        {
        }
    }
}