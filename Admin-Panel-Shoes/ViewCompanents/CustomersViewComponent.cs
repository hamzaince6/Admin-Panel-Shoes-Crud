using Microsoft.AspNetCore.Mvc;

namespace Admin_Panel_Shoes.ViewCompanents;

public class CustomersViewComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}