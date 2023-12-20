using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pustok.Business.Services.Interfaces;
using Pustok.DAL;
using Pustok.Models;
using Pustok.ViewModels;

namespace Pustok.Controllers
{
    public class ShopController : Controller
    {
        private readonly PustokContext _context;
		private readonly IBookService _bookService;

		public ShopController(PustokContext context, IBookService bookService)
        {
            _context = context;
			_bookService = bookService;
		}

        public async Task<IActionResult> Index(int? genreId)
        {
            List<Book> books = genreId is not null 
                                ? await _bookService.GetAllFilteredAsync(x=>x.GenreId == genreId, "Author", "BookImages")
                                : await _bookService.GetAllAsync(null, "Author", "BookImages");
			
            ShopViewModel model = new ShopViewModel()
            {
                Books = books,
                Genres = await _context.Genres.Include(x=>x.Books).ToListAsync(),
            };

            return View(model);
        }
    }
}
