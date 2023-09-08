using BookShopAPI.Application.DTOs.BasketDTOs;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.BasketQueries.GetBasketByUserId
{
    public class GetBasketByUserIdQueryRequest : IRequest<BaseDataResponse<BasketDto>>
    {
        public int UserId { get; set; }
    }
}