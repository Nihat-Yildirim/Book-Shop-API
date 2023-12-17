using BookShopAPI.Application.DTOs.FavoriteBookDTOs;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.FavoriteBookQueries.GetUserFavoriteBooks
{
    public class GetUserFavoriteBooksQueryRequest : IRequest<BaseDataResponse<List<FavoriteBookDto>>>
    {
        public int UserId { get; set; }
    }
}