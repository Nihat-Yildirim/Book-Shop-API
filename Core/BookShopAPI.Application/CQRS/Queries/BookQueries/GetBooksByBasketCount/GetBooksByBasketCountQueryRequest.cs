using BookShopAPI.Application.DTOs.BookDTOs;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.BookQueries.GetBooksByBasketCount
{
    public class GetBooksByBasketCountQueryRequest : IRequest<BaseDataResponse<List<BookDto>>>
    {
        public int Page { get; set; }
        public int Size { get; set; }
    }
}