using BookShopAPI.Domain.Results.Abstracts;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace BookShopAPI.Application.CQRS.Commands.User.UpdateUserAvatar
{
    public class UpdateUserAvatarCommandRequest : IRequest<BaseResponse>
    {
        public int UserId { get; set; }
        public IFormFile? UserAvatar { get; set; }
    }
}