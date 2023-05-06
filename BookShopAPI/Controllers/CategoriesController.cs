using AutoMapper;
using Business.Abstract;
using Entities.Concrete;
using Entities.DTOs.CategoryDTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookShopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        ICategorService _categorService;
        IMapper _mapper;
        public CategoriesController(ICategorService categorService,IMapper mapper)
        {
            _categorService = categorService;
            _mapper = mapper;
        }

        [HttpPost("addcategory")]
        public IActionResult AddCategory(AddedCategoryDto addedCategory)
        {
            var category = _mapper.Map<Category>(addedCategory);

            _categorService.Add(category);

            return Ok("Kategori başarıyla eklendi !");
        }

        [HttpPost("updatecategoryname")]
        public IActionResult UpdateCategoryName(UpdatedCategoryDto updatedCategory)
        {
            var category = _mapper.Map<Category>(updatedCategory);
            
            _categorService.UpdateCategoryName(category);

            return Ok("Kategori başarıyla güncellendi !");
        }

        [HttpGet("getallcategories")]
        public IActionResult GetAllCategories()
        {
            var resultCategories = _categorService.GetAllCategories();  

            return Ok(resultCategories);
        }
    }
}