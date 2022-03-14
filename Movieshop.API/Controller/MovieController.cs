using Microsoft.AspNetCore.Mvc;
using ApplicationCore.Contracts.Repository;
using Infrastructure.Repository;
using ApplicationCore.Entities;
using ApplicationCore.Contracts.Services;


namespace Movieshop.API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService _movieService;
        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;

        }


        [HttpGet]
        [Route("")]
        // http://localhost:73434/api/movies?pagesize=30&page=2&title=ave
        public async Task<IActionResult> GetMoviesByPaginationAsync([FromQuery] int pageSize = 30, [FromQuery] int page = 1, string title = "")
        {
            var movies = await _movieService.GetMoviesByPaginationAsync(pageSize, page, title);
            if (movies == null || movies.Count == 0)
            {
                return NotFound($"no movies found for your search term {title}");
            }
            return Ok(movies);
        }

        [HttpGet]
        [Route("toprevenue")]
        public async Task<IActionResult> GetTopRevenueMoviesAsync()
        {
            var movies = await _movieService.GetTop30GrossingMoviesAsync();

            if (!movies.Any())
            {
                return NotFound();
            }

            return Ok(movies);
        }
        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> DetailsAsync(int id)
        {
            var movie = await _movieService.GetMovieDetailsAsync(id);

            if (movie == null)
                return NotFound();
            return Ok(movie);
        }
        [HttpGet]
        [Route("toprated")]
        public async Task<IActionResult> GetAllMoviesAsync()
        {
            var movies = await _movieService.GetTop30GRatedMoviesAsync();

            if (!movies.Any() || movies.Count == 0)
            {
                return NotFound();
            }
            return Ok(movies);
        }
        [HttpGet]
        [Route("genre/{id:int}")]
        public async Task<IActionResult> GetMovieByGenreIdAsync(int id)
        {
            var genreMovies = await _movieService.MoviesSameGenreAsync(id);

            if (!genreMovies.Any())
            {
                return NotFound();
            }
            return Ok(genreMovies);
        }
    }
}

