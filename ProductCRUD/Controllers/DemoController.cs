using Microsoft.AspNetCore.Mvc;

namespace ProductCRUD.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Message = "This is ViewBag Data";

            ViewData["Info"] = "This is ViewData Data";

            TempData["Notice"] = "This is TempData Data (Survives Redirect)";
            return View();
        }

        public IActionResult TempDataDemo()
        {
            return View();
        }
        public IActionResult RedirectToTempData()
        {
            TempData["Notice"] = "This is TempData Data (Survives Redirect)";
            return RedirectToAction("TempDataDemo");
        }

    }
}
