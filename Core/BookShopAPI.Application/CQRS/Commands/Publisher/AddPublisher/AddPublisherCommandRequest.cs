using BookShopAPI.Domain.Results.Abstracts;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace BookShopAPI.Application.CQRS.Commands.Publisher.AddPublisher
{
    public class AddPublisherCommandRequest : IRequest<BaseResponse>
    {
        public string? Name { get; set; }
        public IFormFile? Logo { get; set; }
    }
}