using FTB.Models;
using FTB.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FTB.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _appDbContext;
        public HomeController(AppDbContext context)
        {
            _appDbContext = context;
        }


        public IActionResult Index()
        {
            HomeViewModel homeViewModel = new HomeViewModel();
            homeViewModel.Sliders = _appDbContext.Sliders.ToList();

            return View(homeViewModel);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Service()
        {
            return View();
        }
    }
}
