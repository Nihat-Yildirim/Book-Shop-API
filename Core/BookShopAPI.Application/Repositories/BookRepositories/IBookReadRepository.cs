using BookShopAPI.Application.DTOs.BookDTOs;
using BookShopAPI.Application.Repositories.Abstracts;
using BookShopAPI.Domain.Entities;
using BookShopAPI.Domain.RequestParameters;
using System.Linq.Expressions;

namespace BookShopAPI.Application.Repositories.BookRepositories
{
    public interface IBookReadRepository : IReadRepository<Book>
    {
        Task<BookForAdminDto> GetSingleBookForAdminDtoAsync(Expression<Func<BookForAdminDto, bool>> filter);
        Task<BookDto> GetSingleBookDtoAsync(Expression<Func<BookDto, bool>> filter);
        Task<List<BookDto>> GetBookDtosAsync(Pagination pagination, Expression<Func<BookDto, bool>> filter = null);
        Task<List<BookForAdminDto>> GetBookForAdminDtosAsync(Pagination pagination, Expression<Func<BookForAdminDto, bool>> filter = null);
    }
}