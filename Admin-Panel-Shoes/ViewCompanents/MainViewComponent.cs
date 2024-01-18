using Admin_Panel_Shoes.Models;
using Microsoft.AspNetCore.Mvc;

namespace Admin_Panel_Shoes.ViewCompanents;

public class MainViewComponent : ViewComponent
{
    private readonly Context _context;

    public MainViewComponent (Context context)
    {
        _context = context;
    }
    
    public IViewComponentResult Invoke()
    {      
        var mains = _context.Mains.ToList();
        return View(mains);
    }
}