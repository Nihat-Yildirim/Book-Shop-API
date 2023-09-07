using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.AddressCommands.UpdateAddress
{
    public class UpdateAddressCommandRequest : IRequest<BaseResponse>
    {
        public int UserId { get; set; }
        public int AddressId { get; set; }
        public string? AddressTitle { get; set; }
        public string? Description { get; set; }
        public string? Province { get; set; }
        public string? District { get; set; }
        public string? Neighbourhood { get; set; }
        public string? OpenAddress { get; set; }
        public bool Selected { get; set; }
    }
}