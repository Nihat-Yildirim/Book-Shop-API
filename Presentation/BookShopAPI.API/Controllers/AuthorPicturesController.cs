using BookShopAPI.API.Controllers.Common;
using BookShopAPI.Application.CQRS.Commands.Author.AddAuthorPicture;
using BookShopAPI.Application.CQRS.Commands.Author.DeleteAuthorPicture;
using BookShopAPI.Application.CQRS.Commands.Author.UpdateAuthorPicture;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BookShopAPI.API.Controllers
{
    public class AuthorPicturesController : BaseController
    {
        public AuthorPicturesController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost]
        public async Task<IActionResult> AddAuthorPicture([FromForm] AddAuthorPictureCommandRequest request)
        {
            return await NoDataResponse(request);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAuthorPicture([FromForm] UpdateAuthorPictureCommandRequest request)
        {
            return await NoDataResponse(request);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAuthorPicture([FromForm] DeleteAuthorPictureCommandRequest request)
        {
            return await NoDataResponse(request);
        }
    }
}
