using Microsoft.AspNetCore.Http.Connections;
using Microsoft.AspNetCore.Mvc;
using PttLesson02Theory.Models;

namespace PttLesson02Theory.Controllers
{
    public class PttProductController : Controller
    {
        public IActionResult PttIndex()
        {
            //Dữ liệu trong đối tượng: ViewBag, viewData, TemData
            ViewBag.Name = "Phạm Tiến Tuân";
            ViewData["productVD"] = "Laptop Dell Vostro";
            TempData["UNI"] = "Trường Đại Học Nguyễn Trãi - NTU";
            return View();
        }

        public IActionResult GetProduct()
        {
            // Tạo mock data product
            PttProduct pttProduct = new PttProduct()
            {
                ProductID = "2410900082",
                ProductName = "Phạm Tiến Tuân",
                YearRelease = 2006,
                Price = 1000
            };
            
            ViewBag.PttProduct = pttProduct;
            ViewData["product"] = pttProduct;
            return View("Product");
        }
    }
}
