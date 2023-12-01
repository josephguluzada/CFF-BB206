using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pronia.CustomExceptions.Slider;
using Pronia.DAL;
using Pronia.Models;
using Pronia.Repositories;
using Pronia.Services;

namespace Pronia.Areas.Manage.Controllers
{
    [Area("manage")]
    public class SliderController : Controller
    {
        private readonly IWebHostEnvironment _env;
        private readonly ISliderService _sliderService;

        public SliderController(ISliderService sliderService)
        {
            _sliderService = sliderService;
        }

        public async Task<IActionResult> Index()
        {
            List<Slider> sliders = await _sliderService.GetAllAsync();
            return View(sliders);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Slider slider)
        {
            if(!ModelState.IsValid) return View();

            try
            {
                await _sliderService.CreateAsync(slider);
            }
            catch (TotalSliderException ex)
            {

                ModelState.AddModelError(ex.PropertyName, ex.Message);
                return View();
            }
            catch(Exception)
            {

            }

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id) 
        {
            try
            {
                await _sliderService.DeleteAsync(id);
            }
            catch (Exception)
            {

                throw;
            }

            return RedirectToAction("index");
        }
    }
}
