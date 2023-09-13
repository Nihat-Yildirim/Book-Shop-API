using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.CommentCommands.DeleteCommentRating
{
    public class DeleteCommentRatingCommandRequest : IRequest<BaseResponse>
    {
        public int UserId { get; set; }
        public int CommentRatingId { get; set; }
    }
}