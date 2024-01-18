using Admin_Panel_Shoes.Models;
using Microsoft.AspNetCore.Mvc;

namespace Admin_Panel_Shoes.ViewCompanents;

public class ServicesViewComponent : ViewComponent
{
    private readonly Context _context;

    public ServicesViewComponent (Context context)
    {
        _context = context;
    }
    
    public IViewComponentResult Invoke()
    {
        var serviceslist = _context.Services.ToList();
        return View(serviceslist);
    }
}