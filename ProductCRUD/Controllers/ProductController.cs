using Microsoft.AspNetCore.Mvc;

namespace ProductCRUD.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
