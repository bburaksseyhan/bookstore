using BookStore.Api.Configurations;
using BookStore.Application.Interfaces;
using BookStore.Application.Requet.BookRequest;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Api.Controllers
{
    [ApiController]
    [Route(RouteConfig.Base)]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        [Route(RouteConfig.Book.GetAll)]
        public IActionResult GetBooks()
        {
            return Ok(_bookService.GetAll());
        }

        [Authorize]
        [HttpPost]
        [Route(RouteConfig.Book.Create)]
        public IActionResult Post([FromBody] CreateBookViewModel createBookViewModel)
        {
            _bookService.Add(createBookViewModel);

            return Ok(createBookViewModel);
        }

        [HttpPost]
        [Route(RouteConfig.Book.Delete)]
        public IActionResult Delete([FromHeader]int bookId)
        {
            var result = _bookService.Remove(bookId);

            return Ok(result);
        }

        [HttpPost]
        [Route(RouteConfig.Book.Detail)]
        public IActionResult Detail([FromHeader]int bookId)
        {
            var result = _bookService.Detail(bookId);

            return Ok(result);
        }
    }
}