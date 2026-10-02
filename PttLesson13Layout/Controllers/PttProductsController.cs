
using Microsoft.AspNetCore.Mvc;

namespace PttLesson13Layout.Controllers
{
    public class PttProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Search(string keyword)
        {
            ViewData["keyword"] = keyword;
            return View();
        }

        public IActionResult Hots()
        {
            return View();
        }
    }
}

