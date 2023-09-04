using BookShopAPI.API.Controllers.Common;
using BookShopAPI.Application.CQRS.Commands.User.AddUserAvatar;
using BookShopAPI.Application.CQRS.Commands.User.DeleteUserAvatar;
using BookShopAPI.Application.CQRS.Commands.User.UpdateUserAvatar;
using BookShopAPI.Application.CQRS.Commands.User.UpdateUserProfile;
using BookShopAPI.Application.CQRS.Queries.User.GetUserByPattern;
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

        [HttpGet("GetUserByPattern")]
        public async Task<IActionResult> GetUserByPattern([FromQuery] GetUserByPatternQueryRequest request)
        {
            return await DataResponse(request);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateUserProfile([FromQuery] UpdateUserProfileCommandRequest request)
        {
            return await NoDataResponse(request);
        }

        [HttpPost("AddUserAvatar")]
        public async Task<IActionResult> AddUserAvatar([FromForm] AddUserAvatarCommandRequest request)
        {
            return await NoDataResponse(request);
        }

        [HttpDelete("DeleteUserAvatar")]
        public async Task<IActionResult> DeleteUserAvatar([FromQuery] DeleteUserAvatarCommandRequest request)
        {
            return await NoDataResponse(request);
        }

        [HttpPut("UpdateUserAvatar")]
        public async Task<IActionResult> UpdateUserAvatar([FromForm] UpdateUserAvatarCommandRequest request)
        {
            return await NoDataResponse(request);
        }
    }
}