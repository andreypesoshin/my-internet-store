using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MyInternetStore.Data;
using MyInternetStore.Domain;
using MyInternetStore.Web.Models;
using MyInternetStore.Web.ViewModels;

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
        
        // https://localhost:5001/Products/Index?category=1&color=2
        // query parameters
        // query string
        public IActionResult Index(SettingsDto settingsDto)
        {
            // SELECT Name, ImageUrl, PriceRub
            // FROM dbo.Products
            // WHERE ... ;

            var products = _context
                .Products // IQueryable<Product>
                .Include(x => x.Category)
                .Where(x => x.Category.Id == settingsDto.CategoryId)
                .ToList();

            var categories = _context
                .Categories
                .Include(x => x.Products.Select(y => y.Category))
                .ToList();

            foreach (var product in products)
            {
                // N+1 queries
                product.Category.Products.First().Category
            }
            
                //
                // .ProjectTo<ProductViewModel>()
                // .ToList(); // IQueryable -> IEnumerable<Product>
            
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

    public class SettingsDto
    {
        public int CategoryId { get; set; }
        
        public int Color { get; set; }
    }
}