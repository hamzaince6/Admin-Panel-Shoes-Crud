using Admin_Panel_Shoes.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace Admin_Panel_Shoes.ViewCompanents;

public class ProductsViewComponent : ViewComponent
{
    private readonly Context _context;

    public ProductsViewComponent(Context context)
    {
        _context = context;
    }
    
    public async Task<ViewViewComponentResult> InvokeAsync()
    {
        var productList = _context.ProductsEnumerable.ToList();
        return View(productList);
    }
}