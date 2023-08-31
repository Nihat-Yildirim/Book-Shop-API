using BookShopAPI.API.Controllers.Common;
using BookShopAPI.Application.CQRS.Commands.User.AddUserAvatar;
using BookShopAPI.Application.CQRS.Commands.User.DeleteUserAvatar;
using BookShopAPI.Application.CQRS.Commands.User.UpdateUserAvatar;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BookShopAPI.API.Controllers
{
    public class UserAvatarsController : BaseController
    {
        public UserAvatarsController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost]
        public async Task<IActionResult> AddUserAvatar([FromForm] AddUserAvatarCommandRequest request)
        {
            return await NoDataResponse(request);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteUserAvatar([FromQuery] DeleteUserAvatarCommandRequest request)
        {
            return await NoDataResponse(request);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateUserAvatar([FromForm] UpdateUserAvatarCommandRequest request)
        {
            return await NoDataResponse(request);
        }
    }
}