using BookShopAPI.Application.Repositories.FavoriteBookRepositories;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Persistence.EntityFramework.Contexts;
using BookShopAPI.Persistence.EntityFramework.Repositories.Abstracts;

namespace BookShopAPI.Persistence.EntityFramework.Repositories.FavoriteBookRepositories
{
    public class FavoriteBookReadRepository : BaseReadRepository<FavoriteBook>, IFavoriteBookReadRepository
    {
        public FavoriteBookReadRepository(BookShopDbContext context) : base(context)
        {
        }
    }
}