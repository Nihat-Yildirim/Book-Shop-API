using BookShopAPI.Domain.Results.Abstracts;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace BookShopAPI.Application.CQRS.Commands.User.AddUserAvatar
{
    public class AddUserAvatarCommandRequest : IRequest<BaseResponse>
    {
        public int UserId { get; set; }
        public IFormFile? UserAvatar { get; set; }
    }
}