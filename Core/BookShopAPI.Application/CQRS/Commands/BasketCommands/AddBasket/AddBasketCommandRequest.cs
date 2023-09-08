using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.BasketCommands.AddBasket
{
    public class AddBasketCommandRequest : IRequest<BaseResponse>
    {
        public int UserId { get; set; }
    }
}