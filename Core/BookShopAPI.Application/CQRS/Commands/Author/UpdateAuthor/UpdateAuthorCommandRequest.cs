using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.Author.UpdateAuthor
{
    public class UpdateAuthorCommandRequest : IRequest<BaseResponse>
    {
        public int AuthorId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Autobiography { get; set; }
    }
}