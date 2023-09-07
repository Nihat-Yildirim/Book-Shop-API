using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.AddressCommands.AddAddress
{
    public class AddAddressCommandRequest : IRequest<BaseResponse>
    {
        public int UserId { get; set; }
        public string? AddressTitle { get; set; }
        public string? Description { get; set; }
        public string? Province { get; set; }
        public string? District { get; set; }
        public string? Neighbourhood { get; set; }
        public string? OpenAddress { get; set; }
    }
}