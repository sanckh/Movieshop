using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Contracts.Repository;
using ApplicationCore.Entities;
using ApplicationCore.Models;


namespace ApplicationCore.Contracts.Repository
{
    public interface IMovieRepository : IRepository<Movie>
    {
        Task<List<Movie>> Get30HighestGrossingMoviesAsync();
        Task<List<Movie>> Get30HighestRatedMoviesAsync();
        Task<decimal> GetMovieRatingAsync(int id);
        Task<List<Movie>> GetMoviesSameGenreAsync(int id);

        Task<PagedResultSet<Movie>> GetMoviesByTitleAsync(int pageSize = 30, int page = 1, string title = "");



    }
}