using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.AuthorCommands.UpdateAuthor
{
    public class UpdateAuthorCommandRequest : IRequest<BaseResponse>
    {
        public int AuthorId { get; set; }
        public string? Name { get; set; }
        public string? Autobiography { get; set; }
    }
}