using ApplicationCore.Contracts.Services;
using Microsoft.AspNetCore.Mvc;
using MovieshopMVC.Models;

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
            var movies = _movieService.GetMoviesByPagination(10, 1, "");
            return View(movies);
        }
    }
}
