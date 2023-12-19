using BookShopAPI.Application.DTOs.BookDTOs;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.BookQueries.GetFavoriteBooksByUserId
{
    public class GetFavoriteBooksByUserIdQueryRequest : IRequest<BaseDataResponse<ResultFavoriteBookDto>>
    {
        public int UserId { get; set; }
        public int Page { get; set; }
        public int Size { get; set; }
    }
}
