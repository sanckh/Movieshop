using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Contracts.Repository;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Models;
using ApplicationCore.Entities;

namespace Infrastructure.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;

        public MovieService(IMovieRepository movierRepository)
        {
            _movieRepository = movierRepository;
        }

        public void AddMovie(MovieCreateRequestModel model)
        {
            Movie movie = new Movie();
            if (model != null)
            {
                movie.BackdropUrl = model.BackdropUrl;
                movie.Title = model.Title;
                movie.Budget = model.Budget;
                movie.ImdbUrl = model.ImdbUrl;
                movie.OriginalLanguage = model.OriginalLanguage;
                movie.Overview = model.Overview;
                movie.PosterUrl = model.PosterUrl;
                movie.Price = model.Price;
                movie.ReleaseDate = model.ReleaseDate;
                movie.Revenue = model.Revenue;
                movie.RunTime = model.RunTime;
                movie.Tagline = model.Tagline;
                movie.Title = model.Title;
                movie.TmdbUrl = model.TmdbUrl;
                _movieRepository.Insert(movie);

            }
        }

        public void DeleteMovie(int id)
        {
            _movieRepository.Delete(id);
        }

        public MovieDetailsResponseModel GetMovieDetails(int id)
        {
            var movieDetails = _movieRepository.GetById(id);
            var rating = _movieRepository.GetMovieRating(id);

            var movieModel = new MovieDetailsResponseModel
            {
                Id = movieDetails.Id,
                Title = movieDetails.Title,
                PosterUrl = movieDetails.PosterUrl,
                BackdropUrl = movieDetails.BackdropUrl,
                Overview = movieDetails.Overview,
                Tagline = movieDetails.Tagline,
                Budget = movieDetails.Budget,
                Revenue = movieDetails.Revenue,
                ImdbUrl = movieDetails.ImdbUrl,
                TmdbUrl = movieDetails.TmdbUrl,
                ReleaseDate = movieDetails.ReleaseDate,
                RunTime = movieDetails.RunTime,
                Price = movieDetails.Price,
                Rating = rating,

            };

            foreach (var genre in movieDetails.GernesOfMovie)
            {
                movieModel.Genres.Add(new GenreModel { Id = genre.GenreId, Name = genre.Genre.Name });
            }

            foreach (var trailer in movieDetails.Trailers)
            {
                movieModel.Trailers.Add(new TrailerResponseModel { Id = trailer.Id, Name = trailer.Name, TrailerUrl = trailer.TrailerUrl });
            }

            foreach (var cast in movieDetails.MovieCast)
            {
                movieModel.Casts.Add(new CastResponseModel { Id = cast.CastId, Name = cast.Cast.Name, Character = cast.Character, ProfilePath = cast.Cast.ProfilePath });
            }

            return movieModel;

        }

        public PagedResultSet<MovieCardResponseModel> GetMoviesByPagination(int pageSize, int page, string title)
        {
            var pagedMovie = _movieRepository.GetMoviesByTitle(pageSize, page, title);
            var pagedMovieCards = new List<MovieCardResponseModel>();

            pagedMovieCards.AddRange(pagedMovie.Data.Select(m => new MovieCardResponseModel
            {
                Id = m.Id,
                Title = m.Title,
                PosterUrl = m.PosterUrl
            }));

            return new PagedResultSet<MovieCardResponseModel>(pagedMovieCards, page, pageSize, pagedMovie.Count);
        }

        public List<MovieCardResponseModel> GetTop30GRatedMovies()
        {
            var topRatedMovies = _movieRepository.Get30HighestRatedMovies();

            var movieCards = new List<MovieCardResponseModel>();
            foreach (var movie in topRatedMovies)
            {
                movieCards.Add(new MovieCardResponseModel
                {
                    Id = movie.Id,
                    Title = movie.Title,
                    PosterUrl = movie.PosterUrl
                });
            }

            return movieCards;
        }

        public List<MovieCardResponseModel> GetTop30GrossingMovies()
        {
            //call MovieRepository and get data from Movies Table
            var movies = _movieRepository.Get30HighestGrossingMovies();

            //map data from movies (List<Movie> to movieCards (List<MovieCardResponseModel>)

            var movieCards = new List<MovieCardResponseModel>();

            foreach(var movie in movies)
            {
                movieCards.Add(new MovieCardResponseModel
                {
                    Id = movie.Id,
                    Title = movie.Title,
                    PosterUrl = movie.PosterUrl
                });
            }
            return movieCards;
        }

        public List<MovieCardResponseModel> MoviesSameGenre(int id)
        {
            var genreMovies = _movieRepository.GetMoviesSameGenre(id);

            var genreModel = new List<MovieCardResponseModel>();

            foreach (var movie in genreMovies)
            {
                genreModel.Add(new MovieCardResponseModel
                {
                    Id = movie.Id,
                    Title = movie.Title,
                    PosterUrl = movie.PosterUrl
                });
            }
            return genreModel;
        }
        public void UpdateMovie(MovieCreateRequestModel model)
        {
            Movie movie = new Movie();
            if (model != null)
            {
                movie.BackdropUrl = model.BackdropUrl;
                movie.Title = model.Title;
                movie.Budget = model.Budget;
                movie.ImdbUrl = model.ImdbUrl;
                movie.OriginalLanguage = model.OriginalLanguage;
                movie.Overview = model.Overview;
                movie.PosterUrl = model.PosterUrl;
                movie.Price = model.Price;
                movie.ReleaseDate = model.ReleaseDate;
                movie.Revenue = model.Revenue;
                movie.RunTime = model.RunTime;
                movie.Tagline = model.Tagline;
                movie.Title = model.Title;
                movie.TmdbUrl = model.TmdbUrl;
                _movieRepository.Update(movie);

            }
        }
    }
}
