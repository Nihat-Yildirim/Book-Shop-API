using BookShopAPI.API.Controllers.Common;
using BookShopAPI.Application.CQRS.Commands.Category.AddCategory;
using BookShopAPI.Application.CQRS.Commands.Category.DeleteCategory;
using BookShopAPI.Application.CQRS.Commands.Category.UpdateCategory;
using BookShopAPI.Application.CQRS.Queries.Category.GetAllCategories;
using BookShopAPI.Application.CQRS.Queries.Category.GetCategoriesByParentId;
using BookShopAPI.Application.CQRS.Queries.Category.GetCategoryById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BookShopAPI.API.Controllers
{
    public class CategoriesController : BaseController
    {
        public CategoriesController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("AddCategory")]
        public async Task<IActionResult> AddCategory([FromQuery] AddCategoryCommandRequest request)
        {
            return await NoDataResponse(request);
        }

        [HttpPut("UpdateCategory")]
        public async Task<IActionResult> UpdateCategory([FromQuery] UpdateCategoryCommandRequest request)
        {
            return await NoDataResponse(request);
        }

        [HttpDelete("DeleteCategory")]
        public async Task<IActionResult> DeleteCategory([FromQuery] DeleteCategoryCommandRequest request)
        {
            return await NoDataResponse(request);
        }

        [HttpGet("GetAllCategories")]
        public async Task<IActionResult> GetAllCategories([FromQuery] GetAllCategoriesQueryRequest request)
        {
            return await DataResponse(request);
        }

        [HttpGet("GetCategoryById")]
        public async Task<IActionResult> GetCategoryById([FromQuery] GetCategoryByIdQueryRequest request)
        {
            return await DataResponse(request);
        }

        [HttpGet("GetCategoriesByParentId")]
        public async Task<IActionResult> GetCategoriesByParentId([FromQuery] GetCategoriesByParentIdQueryRequest request)
        {
            return await DataResponse(request);
        }
    }
}