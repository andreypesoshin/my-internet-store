using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
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

        public ProductsController(ILogger<ProductsController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            using (var context = new MyAppContext())
            {
                var product2 = context.Products.Find(1);
                
            }
            
            /*
            var demoObject = new GenericDemo<decimal>();
            demoObject.Price = 10m;
            
            var demoObject2 = new GenericDemo<string>();
            demoObject2.Price = "20 руб";
            */

            var category = new Category(0, "Игры для ПК");
            var product = new Product(0, "The Witcher", "The Witcher Description", 1500, 20,
                "https://www.ferra.ru/thumb/860x0/filters:quality(75):no_upscale()/imgs/2019/12/30/10/3719514/ab2ecc65a1bdc3db8933e4d945cf6107956185e5.jpg");

            category.Products.Add(product);

            return View();
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