using BookShopAPI.API.Controllers.Common;
using BookShopAPI.Application.CQRS.Commands.User.AddUserAvatar;
using BookShopAPI.Application.CQRS.Commands.User.DeleteUserAvatar;
using BookShopAPI.Application.CQRS.Commands.User.UpdateUserProfile;
using BookShopAPI.Application.CQRS.Queries.User.GetUsers;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BookShopAPI.API.Controllers
{
    public class UsersController :BaseController
    {
        public UsersController(IMediator mediator) : base(mediator) 
        {
        }

        [HttpGet("GetUsers")]
        public async Task<IActionResult> GetUsers([FromQuery] GetUsersQueryRequest request)
        {
            return await DataResponse(request);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateUserProfile([FromQuery] UpdateUserProfileCommandRequest request)
        {
            return await NoDataResponse(request);
        }
    }
}