using LibraryDb.Repositories;
using LibraryDb.DtoModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryDb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookPriceAvgPublisherBookPriceController : ControllerBase
    {
        private readonly BooksRepository _booksRepository;
        public BookPriceAvgPublisherBookPriceController(BooksRepository booksRepository)
        {
            _booksRepository = booksRepository;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_booksRepository.GetBooksPriceAvgPublisherBookPrice());
        }
    }
}
