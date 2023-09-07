using BookShopAPI.Application.DTOs.BookDTOs;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.BookQueries.GetBooksByPublisherId
{
    public class GetBooksByPublisherIdQueryRequest : IRequest<BaseDataResponse<List<BookDto>>>
    {
        public int Id { get; set; }
        public int Page { get; set; }
        public int Size { get; set; }
    }
}