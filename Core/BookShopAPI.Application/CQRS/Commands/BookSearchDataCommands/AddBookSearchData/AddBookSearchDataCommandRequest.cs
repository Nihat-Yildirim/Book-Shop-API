using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.BookSearchDataCommands.AddBookSearchData
{
    public class AddBookSearchDataCommandRequest : IRequest<BaseResponse>
    {
        public int BookId { get; set; }
    }
}