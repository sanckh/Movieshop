using ApplicationCore.Contracts.Services;
using Microsoft.AspNetCore.Mvc;
using MovieshopMVC.Models;
using ApplicationCore.Models;

namespace MovieshopMVC.Controllers
{
    public class MovieController:Controller
    {
        private readonly IMovieService _movieService;
        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }
        public IActionResult Index()
        {
            var movies = _movieService.GetMoviesByPaginationAsync(10, 1, "");
            return View(movies);
        }
        [HttpGet]
        public IActionResult Genre(int id)
        {
            var data = _movieService.MoviesSameGenreAsync(id);
            return View(data);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(MovieCreateRequestModel model)
        {
            try
            {
                _movieService.AddMovieAsync(model);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View(model);
            }
        }
    }
}
