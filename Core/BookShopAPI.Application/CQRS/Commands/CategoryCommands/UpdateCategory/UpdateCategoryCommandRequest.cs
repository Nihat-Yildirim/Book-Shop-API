using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Commands.CategoryCommands.UpdateCategory
{
    public class UpdateCategoryCommandRequest : IRequest<BaseResponse>
    {
        public int CategoryId { get; set; }
        public int ParentCategoryId { get; set; }
        public string? CategoryName { get; set; }
    }
}