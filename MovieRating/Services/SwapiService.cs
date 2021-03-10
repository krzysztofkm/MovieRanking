using MovieRatingApplication.Models;
using RestSharp;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using RestSharp.Serializers.NewtonsoftJson;
using MovieRatingApplication.Interfaces;

namespace MovieRatingApplication.Services
{

    /// <summary>
    /// Implemetns swapi API base operations
    /// </summary>
    public class SwapiService : ISwapiService
    {
        private const string _serviceAsress = "http://swapi.dev";
        private RestClient _restClient;

        public SwapiService()
        {
            _restClient = new RestClient(_serviceAsress);
            _restClient.UseNewtonsoftJson();
        }

        /// <summary>
        /// Return all movies from swapi servie
        /// </summary>
        /// <returns>All movies</returns>
        public List<MovieViewModel> GetAllMovies()
        {
            var request = new RestRequest("api/films/", DataFormat.Json);
            var response = _restClient.Get<MoviesResultModel<MovieViewModel>>(request);

            return response.Data?.Results;
        }

        /// <summary>
        /// Return movie details from swapi
        /// </summary>
        /// <param name="title">Movie title</param>
        /// <returns>Movie details</returns>
        public MovieDetailsViewModel GetMovie(string title)
        {
            var request = new RestRequest("api/films/", DataFormat.Json);
            request.AddQueryParameter("search", title);

            var response = _restClient.Get<MoviesResultModel<MovieDetailsViewModel>>(request);
            return response.Data?.Results?.FirstOrDefault();
        }
    }
}
