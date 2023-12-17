using Microsoft.AspNetCore.Mvc;

namespace Admin_Panel_Shoes.Controllers;

public class AboutController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}