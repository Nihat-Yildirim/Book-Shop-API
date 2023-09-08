using BookShopAPI.API.Controllers.Common;
using BookShopAPI.Application.CQRS.Commands.AuthorCommands.AddAuthor;
using BookShopAPI.Application.CQRS.Commands.AuthorCommands.AddAuthorPicture;
using BookShopAPI.Application.CQRS.Commands.AuthorCommands.DeleteAuthor;
using BookShopAPI.Application.CQRS.Commands.AuthorCommands.DeleteAuthorPicture;
using BookShopAPI.Application.CQRS.Commands.AuthorCommands.UpdateAuthor;
using BookShopAPI.Application.CQRS.Commands.AuthorCommands.UpdateAuthorPicture;
using BookShopAPI.Application.CQRS.Queries.AuthorQueries.GetAllAuthorForAdmin;
using BookShopAPI.Application.CQRS.Queries.AuthorQueries.GetAllAuthors;
using BookShopAPI.Application.CQRS.Queries.AuthorQueries.GetAuthorById;
using BookShopAPI.Application.CQRS.Queries.AuthorQueries.GetAuthorByIdForAdmin;
using BookShopAPI.Application.CQRS.Queries.AuthorQueries.GetAuthorByPattern;
using BookShopAPI.Application.CQRS.Queries.AuthorQueries.GetAuthorByPatternForAdmin;
using BookShopAPI.Infrastructure.Filters;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BookShopAPI.API.Controllers
{
    public class AuthorsController : BaseController
    {
        public AuthorsController(IMediator mediator) : base(mediator)
        {
        }

        //[AuthorizationFilter("Admin")]
        [HttpPost("AddAuthor")]
        public async Task<IActionResult> AddAuthor([FromQuery] AddAuthorCommandRequest request)
        {
            return await NoDataResponse(request);
        }

        [HttpGet("GetAllAuthors")]
        public async Task<IActionResult> GetAllAuthors([FromQuery] GetAllAuthorsQueryRequest request)
        {
            return await DataResponse(request);
        }

        [HttpGet("GetAuthorById")]
        public async Task<IActionResult> GetAuthorById([FromQuery] GetAuthorByIdQueryRequest request)
        {
            return await DataResponse(request);
        }

        [AuthorizationFilter("Admin")]
        [HttpGet("GetAllAuthorForAdmin")]
        public async Task<IActionResult> GetAllAuthorForAdmin([FromQuery] GetAllAuthorsForAdminQueryRequest request)
        {
            return await DataResponse(request);
        }

        [AuthorizationFilter("Admin")]
        [HttpGet("GetAuthorByIdForAdmin")]
        public async Task<IActionResult> GetAuthorByIdForAdmin([FromQuery] GetAuthorByIdForAdminQueryRequest request)
        {
            return await DataResponse(request);
        }

        [AuthorizationFilter("Admin")]
        [HttpDelete("DeleteAuthor")]
        public async Task<IActionResult> DeleteAuthor([FromQuery] DeleteAuthorCommandRequest request)
        {
            return await NoDataResponse(request);
        }

        [AuthorizationFilter("Admin")]
        [HttpPut("UpdateAuthor")]
        public async Task<IActionResult> UpdateAuthor([FromQuery] UpdateAuthorCommandRequest request)
        {
            return await NoDataResponse(request);
        }

        [HttpGet("GetAuthorByPattern")]
        public async Task<IActionResult> GetAuthorByPattern([FromQuery] GetAuthorByPatternQueryRequest request)
        {
            return await DataResponse(request);
        }

        [AuthorizationFilter("Admin")]
        [HttpGet("GetAuthorByPatternForAdmin")]
        public async Task<IActionResult> GetAuthorByPatternForAdmin([FromQuery] GetAuthorByPatternForAdminQueryRequest request)
        {
            return await DataResponse(request);
        }

        //[AuthorizationFilter("Admin")]
        [HttpPost("AddAuthorPicture")]
        public async Task<IActionResult> AddAuthorPicture([FromForm] AddAuthorPictureCommandRequest request)
        {
            return await NoDataResponse(request);
        }

        [AuthorizationFilter("Admin")]
        [HttpPut("UpdateAuthorPicture")]
        public async Task<IActionResult> UpdateAuthorPicture([FromForm] UpdateAuthorPictureCommandRequest request)
        {
            return await NoDataResponse(request);
        }

        [AuthorizationFilter("Admin")]
        [HttpDelete("DeleteAuthorPicture")]
        public async Task<IActionResult> DeleteAuthorPicture([FromForm] DeleteAuthorPictureCommandRequest request)
        {
            return await NoDataResponse(request);
        }
    }
}