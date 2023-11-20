using Eterna.DAL;
using Eterna.Models;
using Eterna.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Eterna.Controllers
{
    public class PortfolioController : Controller
    {
        private readonly AppDbContext _context;

        public PortfolioController(AppDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {

            PortfolioViewModel model = new PortfolioViewModel()
            {
                Categories = _context.Categories.ToList(),
                Portfolios = _context.Portfolios
                            .Include(x=>x.Category)
                            .Include(x=>x.Images).ToList(),
            };

            return View(model);
        }


        public IActionResult Detail(int id)
        {
            Portfolio? portfolio = _context.Portfolios
                                 .Include(x=>x.Category)
                                 .Include(x=>x.Images)
                                 .FirstOrDefault(x=>x.Id == id);
            if(portfolio == null)
            {
                return NotFound();
            }

            return View(portfolio);
        }
    }
}
