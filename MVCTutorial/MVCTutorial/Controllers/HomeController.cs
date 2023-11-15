using Microsoft.AspNetCore.Mvc;

namespace MVCTutorial.Controllers
{
    public class HomeController : Controller
    {
        public JsonResult JsonAction()
        {
            return new JsonResult("name : BB206");
        }

        public ContentResult ContentAction()
        {
            return Content("Hello BB206!");
        }

        public ViewResult MyAction()
        {
            return View();
        }

        public IActionResult MyIndex()
        {
            return View();
        }
        
        public IActionResult Index()
        {
            return View();
        }
       
    }
}
