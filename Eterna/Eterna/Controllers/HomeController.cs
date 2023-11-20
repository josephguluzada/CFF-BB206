using Eterna.DAL;
using Eterna.Models;
using Eterna.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Eterna.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            HomeViewModel homeVM = new HomeViewModel()
            {
                Sliders = _context.Sliders.ToList(),
                Services = _context.Services.ToList(),
            };

            return View(homeVM);
        }
    }
}