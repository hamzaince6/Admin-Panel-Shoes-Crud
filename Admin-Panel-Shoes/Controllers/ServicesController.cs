using Admin_Panel_Shoes.Models;
using Microsoft.AspNetCore.Mvc;

namespace Admin_Panel_Shoes.Controllers;

public class ServicesController : Controller
{
    private readonly Context _context;

    public ServicesController(Context context)
    {
        _context = context;
    }

    // GET
    public IActionResult Index()
    {
        var value = _context.Services.ToList();
        return View(value);
    }
}