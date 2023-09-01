using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.PhoneNumber.AddPhoneNumber
{
    public class AddPhoneNumberCommandRequest : IRequest<BaseResponse>
    {
        public int UserId { get; set; }
        public string? PhoneTitle { get; set; }
        public string? PhoneNumber { get; set; }
    }
}