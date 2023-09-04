using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.Author.DeleteAuthorPicture
{
    public class DeleteAuthorPictureCommandRequest : IRequest<BaseResponse>
    {
        public int AuthorId { get; set; }
    }
}