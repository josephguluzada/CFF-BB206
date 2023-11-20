using Microsoft.AspNetCore.Mvc;

namespace Eterna.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
