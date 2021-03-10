using MovieRatingApplication.Models;
using MovieRatingApplication.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRatingApplication.Interfaces
{
    /// <summary>
    /// Swapi servie intrface with base operations
    /// </summary>
    public interface ISwapiService  
    {
        /// <summary>
        /// Return all movies from swapi servie
        /// </summary>
        /// <returns>All movies</returns>
        List<MovieViewModel> GetAllMovies();

        /// <summary>
        /// Return movie details from swapi
        /// </summary>
        /// <param name="title">Movie title</param>
        /// <returns>Movie details</returns>
        MovieDetailsViewModel GetMovie(string title);
    }
}
