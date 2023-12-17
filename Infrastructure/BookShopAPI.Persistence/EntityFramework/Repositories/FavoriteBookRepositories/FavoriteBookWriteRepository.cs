using BookShopAPI.Application.Repositories.FavoriteBookRepositories;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Persistence.EntityFramework.Contexts;
using BookShopAPI.Persistence.EntityFramework.Repositories.Abstracts;

namespace BookShopAPI.Persistence.EntityFramework.Repositories.FavoriteBookRepositories
{
    public class FavoriteBookWriteRepository : BaseWriteRepository<FavoriteBook>, IFavoriteBookWriteRepository
    {
        public FavoriteBookWriteRepository(BookShopDbContext context) : base(context)
        {
        }
    }
}