using MovieRatingApplication.Interfaces;
using MovieRatingApplication.Models;
using System.Collections.Generic;
using System.Linq;

namespace MovieRatingApplication.BusinessLogic
{
    /// <summary>
    /// Implements (and wrap) movie logic. Uses swapi API (retrive movie infomrations) nad local repository to store ratings
    /// </summary>
    public class MovieLogic : IMovieLogic
    {
        private ISwapiService _swapiProvider;
        private IMovieRatingRepository _dataRepository;

        /// <summary>
        /// Movie constructor
        /// </summary>
        /// <param name="swapiProvider">swapi API provider</param>
        /// <param name="dataRepository">data repository</param>
        public MovieLogic(ISwapiService swapiProvider,IMovieRatingRepository dataRepository)
        {
            _swapiProvider = swapiProvider;
            _dataRepository = dataRepository;
        }
        
        /// <summary>
        /// Return list of all movies from swapi service
        /// </summary>
        /// <returns>List all movies</returns>
        public List<MovieViewModel> GetAllMovies() =>
            _swapiProvider.GetAllMovies();

        /// <summary>
        /// Add to the repository new rate for selected movie
        /// </summary>
        /// <param name="title">Movie title</param>
        /// <param name="userRate">New rate, range 1-10</param>
        /// <returns>True when rate added, otherwise false</returns>
        public bool AddRate(string title, int userRate)
        {
            //TODO: function should return detailed information when failed (e.g. some enum)
            if (string.IsNullOrEmpty(title)) return false;
            if (userRate < 1 || userRate > 10) return false;

            var newRate = new MovieRating()
            {
                Title = title,
                Rate = userRate
            };

            _dataRepository.Add(newRate);

            return true;
        }

        /// <summary>
        /// Return all movie informations including avg rate
        /// </summary>
        /// <param name="title">Movie title</param>
        /// <returns>Movie details</returns>
        public MovieDetailsViewModel GetMovieWithAvgRate(string title)
        {
            var movieDetails = _swapiProvider.GetMovie(title);
            var movieRatings = _dataRepository.Get(title);
            
            if (movieDetails != null)
                movieDetails.Rating = CalcualateAvgRate(movieRatings);

            return movieDetails;
        }

        private decimal CalcualateAvgRate(List<MovieRating> movie)
        {
            decimal rate = 0;
            if (movie?.Count > 0)
                rate = (decimal)movie.Average(x => x.Rate);

            return rate;
        }


    }
}
