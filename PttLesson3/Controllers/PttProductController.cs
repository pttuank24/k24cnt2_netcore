using Microsoft.AspNetCore.Mvc;
using PttLesson3.Models;

namespace PttLesson3.Controllers
{
    [Route("/Danh-sách-sản-phẩm")]
    public class PttProductController : Controller
    {
        //Mock data
        private readonly List<PttProduct> _products = new()
        {
        

        new PttProduct
        {
            PttProductId = "SP001",
            PttProductName = "Laptop Dell Inspiron 15",
            PttYearRealse = 2025,
            PttPrice = 18500000
        },
        new PttProduct
        {
            PttProductId = "SP002",
            PttProductName = "Laptop ASUS Vivobook 15",
            PttYearRealse = 2025,
            PttPrice = 15900000
        },
        new PttProduct
        {
            PttProductId = "SP003",
            PttProductName = "iPhone 16",
            PttYearRealse = 2024,
            PttPrice = 21900000
        },
        new PttProduct
        {
            PttProductId = "SP004",
            PttProductName = "Samsung Galaxy S25",
            PttYearRealse = 2025,
            PttPrice = 20900000
        },
        new PttProduct
        {
            PttProductId = "SP005",
            PttProductName = "iPad Air M3",
            PttYearRealse = 2025,
            PttPrice = 16900000
        },
        new PttProduct
        {
            PttProductId = "SP006",
            PttProductName = "Tai nghe Bluetooth Sony WH-1000XM5",
            PttYearRealse = 2022,
            PttPrice = 7490000
        },
        new PttProduct
        {
            PttProductId = "SP007",
            PttProductName = "Chuột Logitech MX Master 3S",
            PttYearRealse = 2022,
            PttPrice = 1990000
        },
        new PttProduct
        {
            PttProductId = "SP008",
            PttProductName = "Bàn phím cơ Keychron K2",
            PttYearRealse = 2024,
            PttPrice = 1890000
        },
        new PttProduct
        {
            PttProductId = "SP009",
            PttProductName = "Màn hình LG UltraGear 27 inch",
            PttYearRealse = 2025,
            PttPrice = 8290000
        },
        new PttProduct
        {
            PttProductId = "SP010",
            PttProductName = "Ổ cứng SSD Samsung 1TB",
            PttYearRealse = 2024,
            PttPrice = 2490000
        }

    };
        public IActionResult Index()
        {
            return Json(_products);
        }
        // Collection => View
        [Route("all")]
        public IActionResult PttGetAllProduct()
        {
            ViewData["products"] = _products;
            return View();
        }

    }
}
