using BookShopAPI.Application.DTOs.FavoriteBookDTOs;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.FavoriteBookCommands.AddFavoriteBook
{
    public class AddFavoriteBookCommandRequest : IRequest<BaseDataResponse<FavoriteBookDto>>
    {
        public int UserId { get; set; }
        public int BookId { get; set; }
    }
}