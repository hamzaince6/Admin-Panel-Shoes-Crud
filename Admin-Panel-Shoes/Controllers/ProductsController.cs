using Admin_Panel_Shoes.Models;
using Microsoft.AspNetCore.Mvc;

namespace Admin_Panel_Shoes.Controllers
{
    public class ProductsController : Controller
    {
        private readonly Context _context;

        public ProductsController(Context context)
        {
            _context = context;
        }

        // GET
        public IActionResult Index()
        {
            var allProducts = _context.ProductsEnumerable.ToList();
            return View(allProducts);
        }
    }
}