using BookShopAPI.Application.DTOs.CategoryDTOs;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.CategoryQueries.GetParentCategories
{
    public class GetParentCategoriesQueryRequest : IRequest<BaseDataResponse<List<CategoryDto>>>
    {
    }
}