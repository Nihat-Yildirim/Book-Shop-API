using BookShopAPI.Application.DTOs.BookDTOs;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.BookQueries.GetAllBookForAdmin
{
    public class GetAllBookForAdminQueryRequest : IRequest<BaseDataResponse<List<BookForAdminDto>>>
    {
        public int Page { get; set; } = 0;
        public int Size { get; set; } = 5;
    }
}