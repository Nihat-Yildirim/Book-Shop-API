using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.UserCommands.UpdatePassword
{
    public class UpdatePasswordCommandRequest : IRequest<BaseResponse>
    {
        public int UserId { get; set; }
        public string? OldPassword { get; set; }
        public string? NewPassword { get; set; }
    }
}