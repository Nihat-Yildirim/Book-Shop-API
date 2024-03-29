﻿using BookShopAPI.API.Controllers.Common;
using BookShopAPI.Application.CQRS.Commands.AuthorCommands.AddAuthor;
using BookShopAPI.Application.CQRS.Commands.AuthorCommands.AddAuthorPicture;
using BookShopAPI.Application.CQRS.Commands.AuthorCommands.DeleteAuthor;
using BookShopAPI.Application.CQRS.Commands.AuthorCommands.DeleteAuthorPicture;
using BookShopAPI.Application.CQRS.Commands.AuthorCommands.UpdateAuthor;
using BookShopAPI.Application.CQRS.Commands.AuthorCommands.UpdateAuthorPicture;
using BookShopAPI.Application.CQRS.Queries.AuthorQueries.GetAllAuthorForAdmin;
using BookShopAPI.Application.CQRS.Queries.AuthorQueries.GetAllAuthorName;
using BookShopAPI.Application.CQRS.Queries.AuthorQueries.GetAllAuthors;
using BookShopAPI.Application.CQRS.Queries.AuthorQueries.GetAuthorById;
using BookShopAPI.Application.CQRS.Queries.AuthorQueries.GetAuthorByIdForAdmin;
using BookShopAPI.Application.CQRS.Queries.AuthorQueries.GetAuthorByPattern;
using BookShopAPI.Application.CQRS.Queries.AuthorQueries.GetAuthorByPatternForAdmin;
using BookShopAPI.Application.CQRS.Queries.AuthorQueries.GetRecommendAuthorsForSearch;
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
            => await NoDataResponse(request);

        [HttpGet("GetAllAuthors")]
        [CacheFilter(15, 1)]
        public async Task<IActionResult> GetAllAuthors([FromQuery] GetAllAuthorsQueryRequest request)
            => await DataResponse(request);

        [HttpGet("GetAuthorById")]
        [CacheFilter(15, 1)]
        public async Task<IActionResult> GetAuthorById([FromQuery] GetAuthorByIdQueryRequest request)
            => await DataResponse(request);

        //[AuthorizationFilter("Admin")]
        [HttpGet("GetAllAuthorForAdmin")]
        [CacheFilter(15, 1)]
        public async Task<IActionResult> GetAllAuthorForAdmin([FromQuery] GetAllAuthorsForAdminQueryRequest request)
            => await DataResponse(request);

        //[AuthorizationFilter("Admin")]
        [HttpGet("GetAuthorByIdForAdmin")]
        [CacheFilter(15, 1)]
        public async Task<IActionResult> GetAuthorByIdForAdmin([FromQuery] GetAuthorByIdForAdminQueryRequest request)
            => await DataResponse(request);

        //[AuthorizationFilter("Admin")]
        [HttpDelete("DeleteAuthor")]
        public async Task<IActionResult> DeleteAuthor([FromQuery] DeleteAuthorCommandRequest request)
            => await NoDataResponse(request);

        //[AuthorizationFilter("Admin")]
        [HttpPut("UpdateAuthor")]
        public async Task<IActionResult> UpdateAuthor([FromQuery] UpdateAuthorCommandRequest request)
            => await NoDataResponse(request);

        [HttpGet("GetAuthorByPattern")]
        [CacheFilter(15, 1)]
        public async Task<IActionResult> GetAuthorByPattern([FromQuery] GetAuthorByPatternQueryRequest request)
            => await DataResponse(request);

        //[AuthorizationFilter("Admin")]
        [HttpGet("GetAuthorByPatternForAdmin")]
        [CacheFilter(15, 1)]
        public async Task<IActionResult> GetAuthorByPatternForAdmin([FromQuery] GetAuthorByPatternForAdminQueryRequest request)
            => await DataResponse(request);

        //[AuthorizationFilter("Admin")]
        [HttpPost("AddAuthorPicture")]
        public async Task<IActionResult> AddAuthorPicture([FromForm] AddAuthorPictureCommandRequest request)
            => await NoDataResponse(request);

        //[AuthorizationFilter("Admin")]
        [HttpPut("UpdateAuthorPicture")]
        public async Task<IActionResult> UpdateAuthorPicture([FromForm] UpdateAuthorPictureCommandRequest request)
            => await NoDataResponse(request);

        //[AuthorizationFilter("Admin")]
        [HttpDelete("DeleteAuthorPicture")]
        public async Task<IActionResult> DeleteAuthorPicture([FromForm] DeleteAuthorPictureCommandRequest request)
            => await NoDataResponse(request);

        //[AuthorizationFilter("Admin")]
        [HttpGet("GetAllAuthorName")]
        [CacheFilter(15,7.5)]
        public async Task<IActionResult> GetAllAuthorName([FromQuery] GetAllAuthorNameQueryRequest request)
            => await DataResponse(request);

        [HttpGet("GetRecommendAuthorsForSearch")]
        public async Task<IActionResult> GetRecommendAuthorsForSearch([FromQuery] GetRecommendAuthorsForSearchQueryRequest request)
            => await DataResponse(request);
    }
}