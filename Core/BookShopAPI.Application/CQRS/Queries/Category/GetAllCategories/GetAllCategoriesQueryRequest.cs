using BookShopAPI.Application.DTOs.CategoryDTOs;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.Category.GetAllCategories
{
    public class GetAllCategoriesQueryRequest : IRequest<BaseDataResponse<List<CategoryDto>>>
    {
    }
}