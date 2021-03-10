using MovieRatingApplication.Interfaces;
using MovieRatingApplication.Models;
using System.Collections.Generic;
using System.Linq;

namespace MovieRatingApplication.Repository
{
    /// <summary>
    /// Movie rating repository
    /// </summary>
    public class MovieRatingRepository : IMovieRatingRepository
    {
        readonly MovieRatingContext _movieRatingContext;

        public MovieRatingRepository(MovieRatingContext context)
        {
            _movieRatingContext = context;
        }

        /// <summary>
        /// Add new movie rating to the repository
        /// </summary>
        /// <param name="entity"></param>
        public void Add(MovieRating entity)
        {
            _movieRatingContext.MovieRatings.Add(entity);
            _movieRatingContext.SaveChanges();
        }

        /// <summary>
        /// Return movie ratings for movie
        /// </summary>
        /// <param name="title">Movie name</param>
        /// <returns>All movie ratings</returns>
        public List<MovieRating> Get(string title) =>
            _movieRatingContext.MovieRatings.Where(x => x.Title == title).ToList();
    }
}
