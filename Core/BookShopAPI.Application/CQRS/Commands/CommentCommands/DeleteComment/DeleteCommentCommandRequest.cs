using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.CommentCommands.DeleteComment
{
    public class DeleteCommentCommandRequest : IRequest<BaseResponse>
    {
        public int UserId { get; set; }
        public int CommentId { get; set; }
    }
}