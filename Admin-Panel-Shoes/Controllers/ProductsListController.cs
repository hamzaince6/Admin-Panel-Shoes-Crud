using Admin_Panel_Shoes.Models;
using Microsoft.AspNetCore.Mvc;

namespace Admin_Panel_Shoes.Controllers;

public class ProductsListController : Controller
{
    private readonly Context _context;
    public ProductsListController(Context context)
    {
        _context = context;
    }
    
    // GET
    public IActionResult Index()
    {
        var deger = _context.ProductsEnumerable.ToList();
        return View(deger);
    }
}