using BookShopAPI.Application.DTOs.BookDTOs;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.BookQueries.GetBookByNamePattern
{
    public class GetBookByNamePatternQueryRequest : IRequest<BaseDataResponse<List<BookDto>>>
    {
        public int Page { get; set; } = 0;
        public int Size { get; set; } = 5;
        public string? Pattern { get; set; }
    }
}