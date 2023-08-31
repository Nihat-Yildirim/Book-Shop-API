using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.User.UpdateUserProfile
{
    public class UpdateUserProfileCommandRequest : IRequest<BaseResponse>
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
    }
}