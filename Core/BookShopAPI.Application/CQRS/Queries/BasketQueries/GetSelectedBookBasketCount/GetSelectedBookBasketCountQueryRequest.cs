using BookShopAPI.Application.DTOs.Common;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.BasketQueries.GetSelectedBookBasketCount
{
    public class GetSelectedBookBasketCountQueryRequest : IRequest<BaseDataResponse<CountDto>>
    {
        public int BookId { get; set; }
    }
}