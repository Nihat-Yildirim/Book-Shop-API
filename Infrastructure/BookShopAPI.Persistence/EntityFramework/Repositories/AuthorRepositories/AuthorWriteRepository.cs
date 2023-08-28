using BookShopAPI.Application.Repositories.AuthorRepositories;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Persistence.EntityFramework.Contexts;
using BookShopAPI.Persistence.EntityFramework.Repositories.Abstracts;

namespace BookShopAPI.Persistence.EntityFramework.Repositories.AuthorRepositories
{
    public sealed class AuthorWriteRepository : BaseWriteRepository<Author>, IAuthorWriteRepository
    {
        public AuthorWriteRepository(BookShopDbContext context) : base(context)
        {
        }
    }
}