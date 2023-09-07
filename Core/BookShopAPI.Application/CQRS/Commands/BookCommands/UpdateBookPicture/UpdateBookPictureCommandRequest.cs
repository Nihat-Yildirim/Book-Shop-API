using BookShopAPI.Domain.Results.Abstracts;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace BookShopAPI.Application.CQRS.Commands.BookCommands.UpdateBookPicture
{
    public class UpdateBookPictureCommandRequest : IRequest<BaseResponse>
    {
        public int BookId { get; set; }
        public int BookPictureId { get; set; }
        public int ShowOrder { get; set; }
        public IFormFile? Picture { get; set; }
    }
}