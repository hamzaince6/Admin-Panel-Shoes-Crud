using Admin_Panel_Shoes.Models;
using Microsoft.AspNetCore.Mvc;

namespace Admin_Panel_Shoes.ViewCompanents;

public class CustomersViewComponent : ViewComponent
{
    private readonly Context _context;

    public CustomersViewComponent(Context context)
    {
        _context = context;
    }

    public IViewComponentResult Invoke()
    {
        var customers = _context.CustomersEnumerable.ToList();
        return View(customers);
        
    }
}