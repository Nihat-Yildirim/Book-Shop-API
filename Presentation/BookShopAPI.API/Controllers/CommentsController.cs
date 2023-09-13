﻿using BookShopAPI.API.Controllers.Common;
using BookShopAPI.Application.CQRS.Commands.CommentCommands.AddComment;
using BookShopAPI.Application.CQRS.Commands.CommentCommands.AddCommentRating;
using BookShopAPI.Application.CQRS.Commands.CommentCommands.DeleteComment;
using BookShopAPI.Application.CQRS.Commands.CommentCommands.DeleteCommentRating;
using BookShopAPI.Application.CQRS.Commands.CommentCommands.UpdateCommentRating;
using BookShopAPI.Application.CQRS.Queries.CommentQueries.GetAllComment;
using BookShopAPI.Application.CQRS.Queries.CommentQueries.GetChildComments;
using BookShopAPI.Application.CQRS.Queries.CommentQueries.GetCommentsByBookId;
using BookShopAPI.Application.CQRS.Queries.CommentQueries.GetCommentsByUserId;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BookShopAPI.API.Controllers
{
    public class CommentsController : BaseController
    {
        public CommentsController(IMediator mediator) : base(mediator)
        {
        }

        //[AuthorizationFilter("Customer")]
        [HttpPost("AddComment")]
        public async Task<IActionResult> AddComment([FromQuery] AddCommentCommandRequest request)
            => await NoDataResponse(request);

        //[AuthorizationFilter("Customer")]
        [HttpPost("AddCommentRating")]
        public async Task<IActionResult> AddCommentRating([FromQuery] AddCommentRatingCommandRequest request)
            => await NoDataResponse(request);

        //[AuthorizationFilter("Customer")]
        [HttpPut("UpdateCommentRating")]
        public async Task<IActionResult> UpdateCommentRating([FromQuery] UpdateCommentRatingCommandRequest request)
            => await NoDataResponse(request);

        //[AuthorizationFilter("Customer/Admin")]
        [HttpDelete("DeleteComment")]
        public async Task<IActionResult> DeleteComment([FromQuery] DeleteCommentCommandRequest request)
            => await NoDataResponse(request);

        //[AuthorizationFilter("Customer")]
        [HttpDelete("DeleteCommentRating")]
        public async Task<IActionResult> DeleteCommentRating([FromQuery] DeleteCommentRatingCommandRequest request)
            => await NoDataResponse(request);

        [HttpGet("GetCommentsByBookId")]
        public async Task<IActionResult> GetCommentsByBookId([FromQuery] GetCommentsByBookIdQueryRequest request)
            => await DataResponse(request);

        //[AuthorizationFilter("Admin")]
        [HttpGet("GetAllComment")]
        public async Task<IActionResult> GetAllComment([FromQuery] GetAllCommentQueryRequest request)
            => await DataResponse(request);

        [HttpGet("GetChildComments")]
        public async Task<IActionResult> GetChildComments([FromQuery] GetChildCommentsQueryRequest request)
            => await DataResponse(request);

        //[AuthorizationFilter("Admin")]
        [HttpGet("GetCommentsByUserId")]
        public async Task<IActionResult> GetCommentsByUserId([FromQuery] GetCommentsByUserIdQueryRequest request)
            => await DataResponse(request);
    }
}