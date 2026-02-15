using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Sparja.Models;
using Sparja.Services;
using Sparja.Interfaces;

namespace Sparja.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISparjaEnjoyerFormService _service;
        public HomeController(ISparjaEnjoyerFormService service)
        {
            _service = service;
        }

        public IActionResult Index(string name, string email)
        {
            _service.MealSparja(new SparjaEnjoyerForm { Id = new Guid(), Email = email, Name = name, MealSparjaCount = 0 });
            return View(_service.Get());
        }
    }
}
