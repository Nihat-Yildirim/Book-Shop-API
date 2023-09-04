using BookShopAPI.Application.Repositories.Abstracts;
using BookShopAPI.Domain.Entities;
using System.Linq.Expressions;

namespace BookShopAPI.Application.Repositories.AuthorRepositories
{
    public interface IAuthorReadRepository : IReadRepository<Author>
    {
        Task<Author> GetAuthorByAuthorPictureFileAsync(Expression<Func<Author, bool>> filter, bool tracing = true);
    }
}