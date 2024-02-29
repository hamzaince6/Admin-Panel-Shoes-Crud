using Admin_Panel_Shoes.Models;
using Microsoft.AspNetCore.Mvc;

namespace Admin_Panel_Shoes.Controllers;

public class CustomersListController : Controller
{
    private readonly Context _context;
    public CustomersListController(Context context)
    {
        _context = context;
    }
    
    // GET
    public IActionResult Index()
    {
        var deger = _context.CustomersEnumerable.ToList();
        return View(deger);
    }
}