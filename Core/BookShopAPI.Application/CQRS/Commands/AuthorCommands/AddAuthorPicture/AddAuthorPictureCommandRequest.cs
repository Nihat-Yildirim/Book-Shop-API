using BookShopAPI.Domain.Results.Abstracts;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace BookShopAPI.Application.CQRS.Commands.AuthorCommands.AddAuthorPicture
{
    public class AddAuthorPictureCommandRequest : IRequest<BaseResponse>
    {
        public int AuthorId { get; set; }
        public IFormFile? AuthorPicture { get; set; }
    }
}