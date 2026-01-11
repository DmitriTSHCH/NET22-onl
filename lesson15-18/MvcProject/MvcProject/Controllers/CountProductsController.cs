using Microsoft.AspNetCore.Mvc;

namespace MvcProject.Controllers
{
    public class CountProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
