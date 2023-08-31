using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.User.DeleteUserAvatar
{
    public class DeleteUserAvatarCommandRequest : IRequest<BaseResponse>
    {
        public int UserId { get; set; }
    }
}