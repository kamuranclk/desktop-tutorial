
using KonusarakOgren.Models;
using Manager.IService;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace KonusarakOgren.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductService _ProductService;
        public HomeController(ILogger<HomeController> logger, IProductService productService = null)
        {
            _logger = logger;
            _ProductService = productService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}