using MovieRatingApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRatingApplication.Interfaces
{
    /// <summary>
    /// Movie repository interface
    /// </summary>
    public interface IMovieRatingRepository
    {
        /// <summary>
        /// Return all movie ratings from repository
        /// </summary>
        /// <param name="title">Movie title</param>
        /// <returns>All rates</returns>
        List<MovieRating> Get(string title);

        /// <summary>
        /// Add new movie rate
        /// </summary>
        /// <param name="entity"></param>
        void Add(MovieRating entity);
    }
}
