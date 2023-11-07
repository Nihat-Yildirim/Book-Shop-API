using BookShopAPI.Application.DTOs.AddressDTOs;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.AddressQueries.GetAddressByUserAndAddressId
{
    public class GetAddressByUserAndAddressIdQueryRequest : IRequest<BaseDataResponse<AddressDto>>
    {
        public int UserId { get; set; }
        public int AddressId { get; set; }
    }
}