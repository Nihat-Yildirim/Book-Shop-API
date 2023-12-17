using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.FavoriteBookCommands.DeleteFavoriteBook
{
    public class DeleteFavoriteBookCommandRequest : IRequest<BaseResponse>
    {
        public int Id { get; set; }
    }
}