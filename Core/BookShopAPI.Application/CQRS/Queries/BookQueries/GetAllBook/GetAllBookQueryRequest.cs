using BookShopAPI.Application.DTOs.BookDTOs;
using BookShopAPI.Domain.RequestParameters;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.BookQueries.GetAllBook
{
    public class GetAllBookQueryRequest : IRequest<BaseDataResponse<List<BookDto>>>
    {
        public int Page { get; set; } = 0;
        public int Size { get; set; } = 5;
    }
}