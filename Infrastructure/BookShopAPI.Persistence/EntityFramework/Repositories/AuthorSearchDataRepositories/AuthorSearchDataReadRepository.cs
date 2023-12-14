using BookShopAPI.Application.Repositories.AuthorSearchDataRepositories;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Persistence.EntityFramework.Contexts;
using BookShopAPI.Persistence.EntityFramework.Repositories.Abstracts;

namespace BookShopAPI.Persistence.EntityFramework.Repositories.AuthorSearchDataRepositories
{
    public class AuthorSearchDataReadRepository : BaseReadRepository<AuthorSearchData>, IAuthorSearchDataReadRepository
    {
        public AuthorSearchDataReadRepository(BookShopDbContext context) : base(context)
        {
        }
    }
}