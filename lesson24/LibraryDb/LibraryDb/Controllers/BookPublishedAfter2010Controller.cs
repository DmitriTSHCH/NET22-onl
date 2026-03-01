using LibraryDb.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryDb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookPublishedAfter2010Controller : ControllerBase
    {
        private readonly BooksRepository _booksRepository;
        public BookPublishedAfter2010Controller(BooksRepository booksRepository)
        {
            _booksRepository = booksRepository;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_booksRepository.GetBookPublishedAfter2010());
        }
    }
}
