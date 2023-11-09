using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.BasketCommands.UpdateBasketItemSelectedValue
{
    public class UpdateBasketItemSelectedValueCommandRequest : IRequest<BaseResponse>
    {
        public int UserId { get; set; }
        public int BasketId { get; set; }
        public int BasketItemId { get; set; }
        public bool Selected { get; set; }
    }
}