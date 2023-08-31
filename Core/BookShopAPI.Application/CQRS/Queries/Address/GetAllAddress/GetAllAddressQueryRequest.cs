using BookShopAPI.Application.DTOs.AddressDTOs;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.Address.GetAllAddress
{
    public class GetAllAddressQueryRequest : IRequest<BaseDataResponse<List<GetAddressForAdminDto>>>
    {
    }
}