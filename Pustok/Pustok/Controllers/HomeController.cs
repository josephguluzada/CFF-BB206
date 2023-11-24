using Microsoft.AspNetCore.Mvc;
using Pustok.DAL;
using Pustok.ViewModels;

namespace Pustok.Controllers;

public class HomeController : Controller
{
    private readonly PustokContext _context;

    public HomeController(PustokContext context)
    {
        _context = context;
    }
    public IActionResult Index()
    {
        HomeViewModel homeVm = new HomeViewModel()
        {
            Sliders = _context.Sliders.ToList(),
        };
        return View(homeVm);
    }
}