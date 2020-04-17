using BookStore.Api.Configurations;
using BookStore.Application.Interfaces;
using BookStore.Application.Request.CreateRequest;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Api.Controllers
{
    [Authorize]
    [ApiController]
    [Route(RouteConfig.Base)]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        [Route(RouteConfig.Category.GetAll)]
        public IActionResult Get()
        {
            return Ok(_categoryService.GetAll());
        }

        [HttpGet]
        [Route(RouteConfig.Category.Detail)]
        public IActionResult GetCategory([FromHeader]int categoryId)
        {
            var result = _categoryService.Detail(categoryId);

            return Ok(result);
        }

        [HttpPost]
        [Route(RouteConfig.Category.Create)]
        public IActionResult Post([FromBody] CreateCategoryViewModel categoryViewModel)
        {
            _categoryService.Add(categoryViewModel);

            return Ok(categoryViewModel);
        }

        [HttpPost]
        [Route(RouteConfig.Category.Delete)]
        public IActionResult Delete([FromHeader]int categoryId)
        {
            var result = _categoryService.Remove(categoryId);

            return Ok(result);
        }
    }
}
