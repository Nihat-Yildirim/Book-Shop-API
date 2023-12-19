using BookShopAPI.Application.DTOs.FavoriteBookDTOs;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.FavoriteBookQueries.GetSelectedBookFavoriteDatasForDays
{
    public class GetSelectedBookFavoriteDatasForDaysQueryRequest : IRequest<BaseDataResponse<List<FavoriteBookCountForDaysDto>>>
    {
        public int BookId { get; set; }
    }
}