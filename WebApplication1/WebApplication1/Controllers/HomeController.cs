using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(int id)
        {
            int number = 9999999;

            ViewData["number"] = number;
            ViewBag.Number1 = id;
            TempData["name"] = "Ramzes";
            string str = "Salam";
            int numberUlker = 18;
            return View((object)str);

            //return RedirectToAction("Detail");
        }

        public IActionResult Detail()
        {
            
            return View();
        }
    }
}
