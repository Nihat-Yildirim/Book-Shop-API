using BookShopAPI.Application.Repositories.AuthorRepositories;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Persistence.EntityFramework.Contexts;
using BookShopAPI.Persistence.EntityFramework.Repositories.Abstracts;

namespace BookShopAPI.Persistence.EntityFramework.Repositories.AuthorRepositories
{
    public sealed class AuthorReadRepository : BaseReadRepository<Author>, IAuthorReadRepository
    {
        public AuthorReadRepository(BookShopDbContext context) : base(context)
        {
        }
    }
}