using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.AddressCommands.AddAddress
{
    public class AddAddressCommandRequest : IRequest<BaseResponse>
    {
        public int UserId { get; set; }
        public int ProvinceId { get; set; }
        public int DistrictId { get; set; }
        public int NeighbourhoodId { get; set; }
        public string? PhoneNumber { get; set; }
        public string? AddressTitle { get; set; }
        public string? Description { get; set; }
        public string? OpenAddress { get; set; }
    }
}