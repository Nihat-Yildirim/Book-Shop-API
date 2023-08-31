using BookShopAPI.Application.DTOs.AddressDTOs;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.Address.GetAllAddressByUserId
{
    public class GetAllAddressByUserIdQueryRequest : IRequest<BaseDataResponse<List<GetAddressDto>>>
    {
        public int UserId { get; set; }
    }
}