using LibraryDb.Repositories;
using LibraryDb.DtoModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryDb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksWithoutLoanController : ControllerBase
    {
        private readonly BooksRepository _booksRepository;
        public BooksWithoutLoanController(BooksRepository booksRepository)
        {
            _booksRepository = booksRepository;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_booksRepository.GetBooksWithoutLoan());
        }
    }
}
