using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.CommentCommands.UpdateCommentRating
{
    public class UpdateCommentRatingCommandRequest : IRequest<BaseResponse>
    {
        public int UserId { get; set; }
        public int CommentRatingId { get; set; }
        public bool Useful { get; set; }
    }
}