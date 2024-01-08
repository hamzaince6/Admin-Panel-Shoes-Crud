using Admin_Panel_Shoes.Models;
using Microsoft.AspNetCore.Mvc;

namespace Admin_Panel_Shoes.Controllers;

public class AboutController : Controller
{
    
    private readonly Context _context;

    public AboutController(Context context)
    {
        _context = context;
    }
    
    // GET
    public IActionResult Index()
    {
        var aboutlist = _context.Abouts.ToList();
        return View(aboutlist);
    }
}