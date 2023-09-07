using BookShopAPI.Application.DTOs.AddressDTOs;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.AddressQueries.GetAllAddressByUserId
{
    public class GetAllAddressByUserIdQueryRequest : IRequest<BaseDataResponse<List<GetAddressDto>>>
    {
        public int UserId { get; set; }
    }
}