using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.CategoryCommands.DeleteCategory
{
    public class DeleteCategoryCommandRequest : IRequest<BaseResponse>
    {
        public int CategoryId { get; set; }
    }
}