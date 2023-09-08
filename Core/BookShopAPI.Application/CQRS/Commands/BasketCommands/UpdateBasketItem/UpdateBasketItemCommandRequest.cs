using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.BasketCommands.UpdateBasketItem
{
    public class UpdateBasketItemCommandRequest : IRequest<BaseResponse>
    {
        public int UserId { get; set; }
        public int BasketId { get; set; }
        public int BasketItemId { get; set; }
        public int Quantity { get; set; }
    }
}