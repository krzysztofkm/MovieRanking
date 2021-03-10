using MovieRatingApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRatingApplication.BusinessLogic
{
    /// <summary>
    /// Movie operations interface
    /// </summary>
    public interface IMovieLogic
    {
        /// <summary>
        /// Return list of all movies from swapi service
        /// </summary>
        /// <returns>List all movies</returns>
        List<MovieViewModel> GetAllMovies();

        /// <summary>
        /// Return all movie informations including avg rate
        /// </summary>
        /// <param name="title">Movie title</param>
        /// <returns>Movie details</returns>
        MovieDetailsViewModel GetMovieWithAvgRate(string title);
       
        /// <summary>
        /// Add to the repository new rate for selected movie
        /// </summary>
        /// <param name="title">Movie title</param>
        /// <param name="userRate">New rate, range 1-10</param>
        /// <returns>True when rate added, otherwise false</returns>
        bool AddRate(string title, int userRate);
    }
}
