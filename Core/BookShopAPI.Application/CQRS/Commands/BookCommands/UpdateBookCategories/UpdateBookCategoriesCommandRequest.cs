using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.BookCommands.UpdateBookCategories
{
    public class UpdateBookCategoriesCommandRequest : IRequest<BaseResponse>
    {
        public int BookId { get; set; }
        public List<int>? CategoryIds { get; set; }
    }
}