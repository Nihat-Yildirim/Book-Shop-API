using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.BookCommands.DeleteBook
{
    public class DeleteBookCommandRequest : IRequest<BaseResponse>
    {
        public int Id { get; set; }
    }
}