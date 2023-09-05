using BookShopAPI.Domain.Results.Abstracts;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace BookShopAPI.Application.CQRS.Commands.Publisher.UpdatePublisherLogo
{
    public class UpdatePublisherLogoCommandRequest : IRequest<BaseResponse>
    {
        public int PublisherId { get; set; }
        public IFormFile? Logo { get; set; }
    }
}