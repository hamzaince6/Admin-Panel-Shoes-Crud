using Microsoft.AspNetCore.Mvc;

namespace Admin_Panel_Shoes.ViewCompanents;

public class AboutViewComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}