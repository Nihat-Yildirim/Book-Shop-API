using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.UserCommands.DeleteUserAvatar
{
    public class DeleteUserAvatarCommandRequest : IRequest<BaseResponse>
    {
        public int UserId { get; set; }
    }
}