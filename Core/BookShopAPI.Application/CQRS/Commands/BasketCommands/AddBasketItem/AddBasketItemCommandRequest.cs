using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.BasketCommands.AddBasketItem
{
    public class AddBasketItemCommandRequest : IRequest<BaseResponse>
    {
        public int UserId { get; set; }
        public int BasketId { get; set; }
        public int BookId { get; set; }
        public int Quantity { get; set; }
    }
}