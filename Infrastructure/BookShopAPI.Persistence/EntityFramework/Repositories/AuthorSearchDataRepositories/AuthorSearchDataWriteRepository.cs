using BookShopAPI.Application.Repositories.AuthorSearchDataRepositories;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Persistence.EntityFramework.Contexts;
using BookShopAPI.Persistence.EntityFramework.Repositories.Abstracts;

namespace BookShopAPI.Persistence.EntityFramework.Repositories.AuthorSearchDataRepositories
{
    public class AuthorSearchDataWriteRepository : BaseWriteRepository<AuthorSearchData>, IAuthorSearchDataWriteRepository
    {
        public AuthorSearchDataWriteRepository(BookShopDbContext context) : base(context)
        {
        }
    }
}