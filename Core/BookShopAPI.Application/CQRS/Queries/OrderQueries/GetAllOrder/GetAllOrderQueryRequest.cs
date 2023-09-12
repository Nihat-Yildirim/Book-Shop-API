using BookShopAPI.Application.DTOs.OrderDTOs;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.OrderQueries.GetAllOrder
{
    public class GetAllOrderQueryRequest : IRequest<BaseDataResponse<List<OrderForAdminDto>>>
    {
    }
}