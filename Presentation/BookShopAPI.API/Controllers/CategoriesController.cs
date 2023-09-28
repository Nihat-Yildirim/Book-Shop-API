using BookShopAPI.API.Controllers.Common;
using BookShopAPI.Application.CQRS.Commands.CategoryCommands.AddCategory;
using BookShopAPI.Application.CQRS.Commands.CategoryCommands.DeleteCategory;
using BookShopAPI.Application.CQRS.Commands.CategoryCommands.UpdateCategory;
using BookShopAPI.Application.CQRS.Queries.CategoryQueries.GetAllCategories;
using BookShopAPI.Application.CQRS.Queries.CategoryQueries.GetCategoriesByParentId;
using BookShopAPI.Application.CQRS.Queries.CategoryQueries.GetCategoryById;
using BookShopAPI.Application.CQRS.Queries.CategoryQueries.GetParentCategories;
using BookShopAPI.Infrastructure.Filters;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BookShopAPI.API.Controllers
{
    public class CategoriesController : BaseController
    {
        public CategoriesController(IMediator mediator) : base(mediator)
        {
        }

        //[AuthorizationFilter("Admin")]
        [HttpPost("AddCategory")]
        public async Task<IActionResult> AddCategory([FromQuery] AddCategoryCommandRequest request)
            => await NoDataResponse(request);

        [AuthorizationFilter("Admin")]
        [HttpPut("UpdateCategory")]
        public async Task<IActionResult> UpdateCategory([FromQuery] UpdateCategoryCommandRequest request)
            => await NoDataResponse(request);

        [AuthorizationFilter("Admin")]
        [HttpDelete("DeleteCategory")]
        public async Task<IActionResult> DeleteCategory([FromQuery] DeleteCategoryCommandRequest request)
            => await NoDataResponse(request);

        [HttpGet("GetAllCategories")]
        public async Task<IActionResult> GetAllCategories([FromQuery] GetAllCategoriesQueryRequest request)
            => await DataResponse(request);

        [HttpGet("GetParentCategories")]
        public async Task<IActionResult> GetParentCategories([FromQuery] GetParentCategoriesQueryRequest request)
            => await DataResponse(request);

        [HttpGet("GetCategoryById")]
        public async Task<IActionResult> GetCategoryById([FromQuery] GetCategoryByIdQueryRequest request)
            => await DataResponse(request);

        [HttpGet("GetCategoriesByParentId")]
        public async Task<IActionResult> GetCategoriesByParentId([FromQuery] GetCategoriesByParentIdQueryRequest request)
            => await DataResponse(request);
    }
}