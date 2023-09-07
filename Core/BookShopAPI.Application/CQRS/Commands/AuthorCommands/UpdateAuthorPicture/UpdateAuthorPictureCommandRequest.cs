using BookShopAPI.Domain.Results.Abstracts;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace BookShopAPI.Application.CQRS.Commands.AuthorCommands.UpdateAuthorPicture
{
    public class UpdateAuthorPictureCommandRequest : IRequest<BaseResponse>
    {
        public int Id { get; set; }
        public IFormFile? AuthorPicture { get; set; }
    }
}