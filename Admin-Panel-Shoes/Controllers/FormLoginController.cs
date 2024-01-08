using Admin_Panel_Shoes.Models;
using Microsoft.AspNetCore.Mvc;

namespace Admin_Panel_Shoes.Controllers;

public class FormLoginController : Controller
{
    private readonly Context _context;


    public FormLoginController(Context context)
    {
        _context = context;
    }
    
    // GET
    public IActionResult Index()
    {
        var valueform = _context.FormLogin.ToList();
        return View(valueform);
    }
}