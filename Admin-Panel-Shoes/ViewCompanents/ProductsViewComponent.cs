using Microsoft.AspNetCore.Mvc;

namespace Admin_Panel_Shoes.ViewCompanents;

public class ProductsViewComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}