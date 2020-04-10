using BookStore.Application.Interfaces;
using BookStore.Application.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Api.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        [Route("all")]
        public IActionResult Get()
        {
            return Ok(_categoryService.GetCategories());
        }

        [HttpGet]
        [Route("detail")]
        public IActionResult GetCategory([FromHeader]int categoryId)
        {
            var result = _categoryService.GetCategory(categoryId);

            return Ok(result);
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateCategoryViewModel categoryViewModel)
        {
            _categoryService.Create(categoryViewModel);

            return Ok(categoryViewModel);
        }

        [HttpPost]
        [Route("delete")]
        public IActionResult Delete([FromHeader]int categoryId)
        {
            var result = _categoryService.DeleteCategory(categoryId);

            return Ok(result);
        }
    }
}
