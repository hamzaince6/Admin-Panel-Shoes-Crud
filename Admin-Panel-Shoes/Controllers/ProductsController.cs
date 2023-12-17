using Microsoft.AspNetCore.Mvc;

namespace Admin_Panel_Shoes.Controllers;

public class ProductsController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}