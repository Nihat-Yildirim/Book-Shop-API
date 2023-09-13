using BookShopAPI.Application.Repositories.LanguageRepositories;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Persistence.EntityFramework.Contexts;
using BookShopAPI.Persistence.EntityFramework.Repositories.Abstracts;

namespace BookShopAPI.Persistence.EntityFramework.Repositories.LanguageRepositories
{
    public sealed class LanguageWriteRepository : BaseWriteRepository<Language>, ILanguageWriteRepository
    {
        public LanguageWriteRepository(BookShopDbContext context) : base(context)
        {
        }
    }
}