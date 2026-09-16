using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using PttLesson08Models.Models;

using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

namespace PttLesson08Models.Controllers
{
    public class PttHomeController : Controller
    {
        private readonly ILogger<PttHomeController> _logger;

        public PttHomeController(ILogger<PttHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult PttIndex()
        {
            return View();
        }

        public IActionResult PttPrivacy()
        {
            return View();
        }

        public IActionResult PttAbout()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            });
        }
    }
}
