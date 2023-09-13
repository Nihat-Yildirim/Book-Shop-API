using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.CommentCommands.AddCommentRating
{
    public class AddCommentRatingCommandRequest : IRequest<BaseResponse>
    {
        public int UserId { get; set; }
        public int CommentId { get; set; }
        public bool Useful { get; set; }
    }
}