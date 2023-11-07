using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.AddressCommands.UpdateAddressSelectedValue
{
    public class UpdateAddressSelectedValueCommandRequest : IRequest<BaseResponse>
    {
        public int UserId { get; set; }
        public int AddressId { get; set; }
    }
}