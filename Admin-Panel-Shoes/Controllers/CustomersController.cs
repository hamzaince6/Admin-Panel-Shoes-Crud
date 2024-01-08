using Admin_Panel_Shoes.Models;
using Microsoft.AspNetCore.Mvc;

namespace Admin_Panel_Shoes.Controllers;

public class CustomersController : Controller
{
    private readonly Context _context;


    public CustomersController(Context context)
    {
        _context = context;
    }
    
    // GET
    public IActionResult Index()
    {
        var value = _context.CustomersEnumerable.ToList();
        return View(value);
    }
}