using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.CommentCommands.AddComment
{
    public class AddCommentCommandRequest : IRequest<BaseResponse>
    {
        public int BookId { get; set; }
        public int UserId { get; set; }
        public int ParentCommentId { get; set; }
        public string? Comment { get; set; }
    }
}