using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.Address.DeleteAddress
{
    public class DeleteAddressCommandRequest : IRequest<BaseResponse>
    {
        public int UserId { get; set; }
        public int AddressId { get; set; }
    }
}