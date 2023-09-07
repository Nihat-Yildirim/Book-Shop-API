using BookShopAPI.Application.DTOs.BookDTOs;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.BookQueries.GetBookByNamePatternForAdmin
{
    public class GetBookByNamePatternForAdminQueryRequest : IRequest<BaseDataResponse<List<BookForAdminDto>>>
    {
        public int Page { get; set; } = 0;
        public int Size { get; set; } = 5;
        public string? Pattern { get; set; }
    }
}