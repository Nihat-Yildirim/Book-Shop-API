using BookShopAPI.Application.Repositories.Abstracts;
using BookShopAPI.Domain.Entities;

namespace BookShopAPI.Application.Repositories.FavoriteBookRepositories
{
    public interface IFavoriteBookWriteRepository : IWriteRepository<FavoriteBook>
    {
    }
}