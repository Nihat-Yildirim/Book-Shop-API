using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.PhoneNumberCommands.DeletePhoneNumber
{
    public class DeletePhoneNumberCommandRequest : IRequest<BaseResponse>
    {
        public int UserId { get; set; }
        public int PhoneId { get; set; }
    }
}