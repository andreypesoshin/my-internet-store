using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyInternetStore.Data;
using MyInternetStore.Domain;
using MyInternetStore.Web.Models;

namespace MyInternetStore.Web.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ILogger<ProductsController> _logger;
        private readonly MyAppContext _context;

        public ProductsController(ILogger<ProductsController> logger, MyAppContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var products = _context.Products.ToList();
            
            return View(products);
        }

        public IActionResult Privacy()
        {
            return View("");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}