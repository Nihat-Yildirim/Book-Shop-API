using BookShopAPI.Application.DTOs.BasketDTOs;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.BasketQueries.GetAllBasket
{
    public class GetAllBasketQueryRequest : IRequest<BaseDataResponse<List<BasketForAdminDto>>>
    {
    }
}