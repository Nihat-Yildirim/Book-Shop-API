using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.OrderCommands.UpdateOrder
{
    public class UpdateOrderCommandRequest : IRequest<BaseResponse>
    {
        public int OrderId { get; set; }
        public bool Comfirm { get; set; }
        public bool Send { get; set; }
    }
}