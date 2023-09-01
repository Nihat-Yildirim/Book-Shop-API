using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.PhoneNumber.UpdatePhoneNumber
{
    public class UpdatePhoneNumberCommandRequest : IRequest<BaseResponse>
    {
        public int UserId { get; set; }
        public int PhoneId { get; set; }
        public string? PhoneTitle { get; set; }
        public string? PhoneNumber { get; set; }
        public bool Selected { get; set; }
    }
}