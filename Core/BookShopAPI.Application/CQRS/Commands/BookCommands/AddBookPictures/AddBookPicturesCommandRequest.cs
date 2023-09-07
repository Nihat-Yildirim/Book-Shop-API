using BookShopAPI.Domain.Results.Abstracts;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace BookShopAPI.Application.CQRS.Commands.BookCommands.AddBookPictures
{
    public class AddBookPicturesCommandRequest : IRequest<BaseResponse>
    {
        public int BookId { get; set; }
        public IFormFileCollection? Pictures { get; set; }
    }
}