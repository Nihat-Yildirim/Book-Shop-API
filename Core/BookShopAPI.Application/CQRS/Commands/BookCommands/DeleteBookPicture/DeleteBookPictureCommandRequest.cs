using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.BookCommands.DeleteBookPicture
{
    public class DeleteBookPictureCommandRequest : IRequest<BaseResponse>
    {
        public int BookId { get; set; }
        public int BookPictureId { get; set; }
    }
}