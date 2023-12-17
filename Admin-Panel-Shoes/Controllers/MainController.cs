using Microsoft.AspNetCore.Mvc;

namespace Admin_Panel_Shoes.Controllers;

public class MainController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}