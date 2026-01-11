using Microsoft.AspNetCore.Mvc;
using MvcProject.Interfaces;
using MvcProject.Models;
using MvcProject.Services;
using System.Xml.Linq;

namespace MvcProject.Controllers
{
    public class ProductsController : Controller
    {

        private readonly IProductService _service;

        public ProductsController(IProductService service)
        {
            _service = service;
        }

        public IActionResult Index(/*string action,*/ float? productId, string? name, string? category, string? description)
        {
            /*switch (action)
            {
                case "delete":
                    _service.DeleteProduct(Convert.ToInt32(productId));
                    break;
                case "add":
                    _service.AddProduct(name?? "*", category, description);
                    break;
                case "redact":
                    break;
            }*/

            if (productId == null && name != null)
            {
                _service.AddProduct(name, category, description);
            }
            else if (productId != null && name == null && category == null && description == null)
            {
                _service.DeleteProduct(Convert.ToInt32(productId));
            }
            else if (productId != null && (name != null || category != null || description != null))
            {
                _service.RedactProduct(Convert.ToInt32(productId), name, category, description);
            }

            /*if (name != null)
            {
                _service.AddProduct(name, category, description);
            }
            if (productId != null)
            {
                _service.DeleteProduct(Convert.ToInt32(productId));
            }*/

            return View(_service.GetProducts());
        }
    }
}
