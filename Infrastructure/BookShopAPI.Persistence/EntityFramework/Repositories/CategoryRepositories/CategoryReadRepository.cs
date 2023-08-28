using BookShopAPI.Application.Repositories.CategoryRepositories;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Persistence.EntityFramework.Contexts;
using BookShopAPI.Persistence.EntityFramework.Repositories.Abstracts;

namespace BookShopAPI.Persistence.EntityFramework.Repositories.CategoryRepositories
{
    public sealed class CategoryReadRepository : BaseReadRepository<Category>, ICategoryReadRepository
    {
        public CategoryReadRepository(BookShopDbContext context) : base(context)
        {
        }
    }
}