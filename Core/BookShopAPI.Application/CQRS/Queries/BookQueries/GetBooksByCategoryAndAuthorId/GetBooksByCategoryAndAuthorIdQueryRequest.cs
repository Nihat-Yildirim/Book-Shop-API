using BookShopAPI.Application.DTOs.BookDTOs;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.BookQueries.GetBooksByCategoryAndAuthorId
{
    public class GetBooksByCategoryAndAuthorIdQueryRequest : IRequest<BaseDataResponse<List<BookDto>>>
    {
        public int BookId { get; set; }
        public int CategoryId { get; set; }
        public int AuthorId { get; set; }
    }
}