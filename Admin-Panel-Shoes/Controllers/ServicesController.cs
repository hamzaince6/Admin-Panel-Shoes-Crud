using Microsoft.AspNetCore.Mvc;

namespace Admin_Panel_Shoes.Controllers;

public class ServicesController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}