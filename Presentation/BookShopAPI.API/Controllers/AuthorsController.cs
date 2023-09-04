using BookShopAPI.API.Controllers.Common;
using BookShopAPI.Application.CQRS.Commands.Author.AddAuthor;
using BookShopAPI.Application.CQRS.Commands.Author.DeleteAuthor;
using BookShopAPI.Application.CQRS.Commands.Author.UpdateAuthor;
using BookShopAPI.Application.CQRS.Queries.Author.GetAllAuthorForAdmin;
using BookShopAPI.Application.CQRS.Queries.Author.GetAllAuthors;
using BookShopAPI.Application.CQRS.Queries.Author.GetAuthorById;
using BookShopAPI.Application.CQRS.Queries.Author.GetAuthorByIdForAdmin;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BookShopAPI.API.Controllers
{
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
    }
}