using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.BookCommands.UpdateBookDescription
{
    public class UpdateBookDescriptionCommandRequest : IRequest<BaseResponse>
    {
        public int BookId { get; set; }
        public string? Description { get; set; }
    }
}