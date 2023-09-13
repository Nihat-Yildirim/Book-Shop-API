using BookShopAPI.API.Controllers.Common;
using BookShopAPI.Application.CQRS.Commands.UserCommands.AddUserAvatar;
using BookShopAPI.Application.CQRS.Commands.UserCommands.DeleteUserAvatar;
using BookShopAPI.Application.CQRS.Commands.UserCommands.UpdateUserAvatar;
using BookShopAPI.Application.CQRS.Commands.UserCommands.UpdateUserProfile;
using BookShopAPI.Application.CQRS.Queries.UserQueries.GetUserByPattern;
using BookShopAPI.Application.CQRS.Queries.UserQueries.GetUserProfile;
using BookShopAPI.Application.CQRS.Queries.UserQueries.GetUsers;
using BookShopAPI.Infrastructure.Filters;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BookShopAPI.API.Controllers
{
    public class UsersController :BaseController
    {
        public UsersController(IMediator mediator) : base(mediator) 
        {
        }

        //[AuthorizationFilter("Admin")]
        [HttpGet("GetUsers")]
        public async Task<IActionResult> GetUsers([FromQuery] GetUsersQueryRequest request)
            => await DataResponse(request);

        //[AuthorizationFilter("Admin")]
        [HttpGet("GetUserByPattern")]
        public async Task<IActionResult> GetUserByPattern([FromQuery] GetUserByPatternQueryRequest request)
            => await DataResponse(request);

        //[AuthorizationFilter("Admin/Customer")]
        [HttpPut]
        public async Task<IActionResult> UpdateUserProfile([FromQuery] UpdateUserProfileCommandRequest request)
            => await NoDataResponse(request);

        //[AuthorizationFilter("Admin/Customer")]
        [HttpPost("AddUserAvatar")]
        public async Task<IActionResult> AddUserAvatar([FromForm] AddUserAvatarCommandRequest request)
            => await NoDataResponse(request);

        //[AuthorizationFilter("Admin/Customer")]
        [HttpDelete("DeleteUserAvatar")]
        public async Task<IActionResult> DeleteUserAvatar([FromQuery] DeleteUserAvatarCommandRequest request)
            => await NoDataResponse(request);

        //[AuthorizationFilter("Admin/Customer")]
        [HttpPut("UpdateUserAvatar")]
        public async Task<IActionResult> UpdateUserAvatar([FromForm] UpdateUserAvatarCommandRequest request)
            => await NoDataResponse(request);

        //[AuthorizationFilter("Admin/Customer")]
        [HttpGet("GetUserProfile")]
        public async Task<IActionResult> GetUserProfile([FromQuery] GetUserProfileQueryRequest request)
            => await DataResponse(request);
    }
}