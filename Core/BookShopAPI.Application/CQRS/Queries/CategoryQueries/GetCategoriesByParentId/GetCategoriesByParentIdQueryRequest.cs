using BookShopAPI.Application.DTOs.CategoryDTOs;
using BookShopAPI.Domain.Results.Abstracts;
using MediatR;

namespace BookShopAPI.Application.CQRS.Queries.CategoryQueries.GetCategoriesByParentId
{
    public class GetCategoriesByParentIdQueryRequest : IRequest<BaseDataResponse<List<CategoryDto>>>
    {
        public int ParentId { get; set; }
    }
}