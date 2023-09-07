using BookShopAPI.Application.Repositories.Abstracts;
using BookShopAPI.Domain.Entities;
using System.Linq.Expressions;

namespace BookShopAPI.Application.Repositories.BookPictureRepositories
{
    public interface IBookPictureReadRepository : IReadRepository<BookPicture>
    {
        Task<List<BookPicture>> GetBookPicturesWithPictureFileAsync(Expression<Func<BookPicture, bool>> filter,bool tracing = true);
    }
}