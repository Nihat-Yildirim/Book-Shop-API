using BookShopAPI.Application.DTOs.CategoryDTOs;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.CategoryQueries.GetAllCategories
{
    public class GetAllCategoriesQueryRequest : IRequest<BaseDataResponse<List<CategoryDto>>>
    {
    }
}