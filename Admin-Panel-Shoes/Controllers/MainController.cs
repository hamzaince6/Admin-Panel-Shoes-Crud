using Admin_Panel_Shoes.Models;
using Microsoft.AspNetCore.Mvc;

namespace Admin_Panel_Shoes.Controllers
{
    public class MainController : Controller
    {
        private readonly Context _context;

        public MainController(Context context)
        {
            _context = context;
        }

        // GET
        public IActionResult Index()
        {
            var value = _context.Mains.ToList();
            return View(value);
        }

        public PartialViewResult ProductMain()
        {
            var Productitem = _context.ProductsEnumerable.ToList();
            return PartialView(Productitem);
        }
        
        
        
    }
}