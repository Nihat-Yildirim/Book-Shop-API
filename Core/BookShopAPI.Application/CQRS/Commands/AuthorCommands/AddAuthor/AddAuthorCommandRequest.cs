using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.AuthorCommands.AddAuthor
{
    public class AddAuthorCommandRequest : IRequest<BaseResponse>
    {
        public string? Name { get; set; }
        public string? Autobiography { get; set; }
    }
}