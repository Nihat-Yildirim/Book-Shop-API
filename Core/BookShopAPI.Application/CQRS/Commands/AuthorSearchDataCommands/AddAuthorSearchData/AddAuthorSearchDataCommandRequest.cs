using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.AuthorSearchDataCommands.AddAuthorSearchData
{
    public class AddAuthorSearchDataCommandRequest : IRequest<BaseResponse>
    {
        public int AuthorId { get; set; }
    }
}