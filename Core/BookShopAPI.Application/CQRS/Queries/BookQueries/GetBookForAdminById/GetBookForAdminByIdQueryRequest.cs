using BookShopAPI.Application.DTOs.BookDTOs;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.BookQueries.GetBookForAdminById
{
    public class GetBookForAdminByIdQueryRequest : IRequest<BaseDataResponse<BookForAdminDto>>
    {
        public int Id { get; set; }
    }
}