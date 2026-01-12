using Microsoft.AspNetCore.Mvc;
using MvcProject.Interfaces;

namespace MvcProject.Controllers
{
    public class CountProductsController : Controller
    {
        private readonly IProductService _service;

        public CountProductsController(IProductService service)
        {
            _service = service;
        }
        public IActionResult Index()
        {
            _service.GetProductCount();
            return View();
        }
    }
}
