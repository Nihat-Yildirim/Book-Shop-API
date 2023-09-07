using BookShopAPI.Application.DTOs.AddressDTOs;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.AddressQueries.GetAllAddress
{
    public class GetAllAddressQueryRequest : IRequest<BaseDataResponse<List<GetAddressForAdminDto>>>
    {
    }
}