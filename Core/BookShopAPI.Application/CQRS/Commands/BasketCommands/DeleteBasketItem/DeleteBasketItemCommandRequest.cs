using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.BasketCommands.DeleteBasketItem
{
    public class DeleteBasketItemCommandRequest : IRequest<BaseResponse>
    {
        public int UserId { get; set; }
        public int BasketId { get; set; }
        public int BasketItemId { get; set; }
    }
}