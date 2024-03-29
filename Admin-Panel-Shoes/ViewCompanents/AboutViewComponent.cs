﻿using Admin_Panel_Shoes.Models;
using Microsoft.AspNetCore.Mvc;

namespace Admin_Panel_Shoes.ViewCompanents;

public class AboutViewComponent : ViewComponent
{
    private readonly Context _context;

    public AboutViewComponent(Context context)
    {
        _context = context;
    }

    public IViewComponentResult Invoke()
    {
        var aboutlist = _context.Abouts.ToList();
        return View(aboutlist);
        
    }
}