using Admin_Panel_Shoes.Models;
using Microsoft.AspNetCore.Mvc;

namespace Admin_Panel_Shoes.Controllers;

public class CustomersAdminController : Controller
{
    private readonly Context _context;
    public CustomersAdminController(Context context)
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