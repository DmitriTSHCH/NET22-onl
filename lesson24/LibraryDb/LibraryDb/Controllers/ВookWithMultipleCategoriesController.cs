using LibraryDb.Repositories;
using LibraryDb.DtoModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryDb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ВookWithMultipleCategoriesController : ControllerBase
    {
        private readonly BooksRepository _booksRepository;
        public ВookWithMultipleCategoriesController(BooksRepository booksRepository)
        {
            _booksRepository = booksRepository;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_booksRepository.GetBookWithMultipleCategories());
        }
    }
}
