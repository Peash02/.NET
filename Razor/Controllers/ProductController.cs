using Microsoft.AspNetCore.Mvc;
using Razor.Models;

namespace Razor.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            List<Product> products = new List<Product>
            {
                new Product { Id = 1, Name = "Laptop", Price = 55000, Quantity = 2,Description = "This is a High-End Laptop WIth RTX 6090 and Intel i12 Processor."},
                new Product { Id = 2, Name = "SmartPhone", Price = 80000 , Quantity = 5 ,Description = "This is a High-End Smartphone with SnapDragon 50 Elite Ultra Chip with 10000mAH Battery."},
                new Product { Id = 3, Name = "Headphones", Price = 20000 , Quantity = 10,Description = "This is a Headphones with ANC and 69mm Drivers in Red Colour and lasts 50 days on one charge."}
            };

            return View(products);
        }
    }
}
