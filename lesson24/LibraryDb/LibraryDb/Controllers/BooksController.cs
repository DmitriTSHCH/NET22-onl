using LibraryDb.Interfaces;
using LibraryDb.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryDb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BooksController (IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpPost]
        public IActionResult Add(int id, string title, string ISBN, DateOnly publicationYear, float price, int authorId, int publisherId)
        {
            _bookService.Add(id, title, ISBN, publicationYear, price, authorId, publisherId);
            return Ok();
        }
    }
}
