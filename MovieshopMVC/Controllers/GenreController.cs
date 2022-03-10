using Microsoft.AspNetCore.Mvc;
using ApplicationCore.Models;
using ApplicationCore.Contracts.Services;

namespace MovieshopMVC.Controllers
{
    public class GenreController:Controller
    {
        private readonly IGenreService _genreService;
        public GenreController(IGenreService genreService)
        {
            _genreService = genreService;

        }
        public IActionResult Index()
        {
            ViewBag.CompanyName = "Antra";
            ViewData["CurrentDate"] = DateTime.Now;
            var data = _genreService.GetAllGenresAsync();
            return View(data);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(GenreModel model)
        {
            if (ModelState.IsValid)
            {
                _genreService.InsertGenreAsync(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public IActionResult Delete(int id)
        {
            try
            {
                _genreService.DeleteGenreAsync(id);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index");
            }
        }
    }
}
