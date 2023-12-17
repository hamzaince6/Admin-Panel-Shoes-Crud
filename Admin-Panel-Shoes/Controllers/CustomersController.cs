using Microsoft.AspNetCore.Mvc;

namespace Admin_Panel_Shoes.Controllers;

public class CustomersController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}