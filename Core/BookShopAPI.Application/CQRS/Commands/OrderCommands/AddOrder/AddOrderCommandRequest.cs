using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.OrderCommands.AddOrder
{
    public class AddOrderCommandRequest : IRequest<BaseResponse>
    {
        public int BasketId { get; set; }
        public int UserId { get; set; }
        public int AddressId { get; set; }
        public int PhoneId { get; set; }
        public float TotalPayment { get; set; }
    }
}