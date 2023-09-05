using BookShopAPI.API.Controllers.Common;
using BookShopAPI.Application.CQRS.Commands.Author.AddAuthor;
using BookShopAPI.Application.CQRS.Commands.Author.AddAuthorPicture;
using BookShopAPI.Application.CQRS.Commands.Author.DeleteAuthor;
using BookShopAPI.Application.CQRS.Commands.Author.DeleteAuthorPicture;
using BookShopAPI.Application.CQRS.Commands.Author.UpdateAuthor;
using BookShopAPI.Application.CQRS.Commands.Author.UpdateAuthorPicture;
using BookShopAPI.Application.CQRS.Queries.Author.GetAllAuthorForAdmin;
using BookShopAPI.Application.CQRS.Queries.Author.GetAllAuthors;
using BookShopAPI.Application.CQRS.Queries.Author.GetAuthorById;
using BookShopAPI.Application.CQRS.Queries.Author.GetAuthorByIdForAdmin;
using BookShopAPI.Application.CQRS.Queries.Author.GetAuthorByPattern;
using BookShopAPI.Application.CQRS.Queries.Author.GetAuthorByPatternForAdmin;
using BookShopAPI.Infrastructure.Filters;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BookShopAPI.API.Controllers
{
    [AuthenticationFilter("Admin")]
    public class AuthorsController : BaseController
    {
        public AuthorsController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost]
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

        [HttpGet("GetAllAuthorForAdmin")]
        public async Task<IActionResult> GetAllAuthorForAdmin([FromQuery] GetAllAuthorsForAdminQueryRequest request)
        {
            return await DataResponse(request);
        }

        [HttpGet("GetAuthorByIdForAdmin")]
        public async Task<IActionResult> GetAuthorByIdForAdmin([FromQuery] GetAuthorByIdForAdminQueryRequest request)
        {
            return await DataResponse(request);
        }

        [HttpDelete("DeleteAuthor")]
        public async Task<IActionResult> DeleteAuthor([FromQuery] DeleteAuthorCommandRequest request)
        {
            return await NoDataResponse(request);
        }

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

        [HttpGet("GetAuthorByPatternForAdmin")]
        public async Task<IActionResult> GetAuthorByPatternForAdmin([FromQuery] GetAuthorByPatternForAdminQueryRequest request)
        {
            return await DataResponse(request);
        }

        [HttpPost("AddAuthorPicture")]
        public async Task<IActionResult> AddAuthorPicture([FromForm] AddAuthorPictureCommandRequest request)
        {
            return await NoDataResponse(request);
        }

        [HttpPut("UpdateAuthorPicture")]
        public async Task<IActionResult> UpdateAuthorPicture([FromForm] UpdateAuthorPictureCommandRequest request)
        {
            return await NoDataResponse(request);
        }

        [HttpDelete("DeleteAuthorPicture")]
        public async Task<IActionResult> DeleteAuthorPicture([FromForm] DeleteAuthorPictureCommandRequest request)
        {
            return await NoDataResponse(request);
        }
    }
}