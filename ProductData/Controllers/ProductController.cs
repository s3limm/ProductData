using Microsoft.AspNetCore.Mvc;
using ProductData.Models;

namespace ProductData.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            string userName = "Yavuz";
            return View(userName as object);
        }

        public IActionResult ShowItemInfo()
        {
            Product product = new Product();
            product.UnitPrice = 5000;
            product.itemName = "Televizyon";
            return View(product);
        }
    }
}
