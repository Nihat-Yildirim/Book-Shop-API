using BookShopAPI.Application.DTOs.BookDTOs;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.BookQueries.GetBooksByCategoryAndAuthorId
{
    public class GetBooksByCategoryAndAuthorIdQueryRequest : IRequest<BaseDataResponse<List<BookDto>>>
    {
        public int BookId { get; set; }
        public int[]? CategoryIds { get; set; }
        public int[]? AuthorIds { get; set; }
    }
}