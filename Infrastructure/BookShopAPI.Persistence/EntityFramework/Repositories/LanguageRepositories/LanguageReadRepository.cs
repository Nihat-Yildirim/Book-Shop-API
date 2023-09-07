using BookShopAPI.Application.Repositories.LanguageRepositories;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Persistence.EntityFramework.Contexts;
using BookShopAPI.Persistence.EntityFramework.Repositories.Abstracts;

namespace BookShopAPI.Persistence.EntityFramework.Repositories.LanguageRepositories
{
    public class LanguageReadRepository : BaseReadRepository<Language>, ILanguageReadRepository
    {
        public LanguageReadRepository(BookShopDbContext context) : base(context)
        {
        }
    }
}