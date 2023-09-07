using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.BookCommands.UpdateBookAuthors
{
    public class UpdateBookAuthorsCommandRequest : IRequest<BaseResponse>
    {
        public int BookId { get; set; }
        public List<int>? AuthorIds { get; set; }
    }
}