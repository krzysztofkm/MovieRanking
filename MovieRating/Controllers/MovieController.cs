using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieRatingApplication.BusinessLogic;
using MovieRatingApplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRatingApplication.Controllers
{
    public class MovieController : Controller
    {
        IMovieLogic _moviePrvider;
        public MovieController(IMovieLogic movieProvider)
        {
            _moviePrvider = movieProvider;
        }

        // GET: MovieController
        public ActionResult Index()
        {
            var movies = _moviePrvider.GetAllMovies();
            return View(movies);
        }

        // GET: MovieController/Details/Title
        public ActionResult Details(string title)
        {
            var movieDetails = _moviePrvider.GetMovieWithAvgRate(title);
            ViewBag.MovieTitle = title;
            return View(movieDetails);
        }

        [HttpPost]
        public ActionResult Rate(int rate, string MovieTitle)
        {
            _moviePrvider.AddRate(MovieTitle, rate);
            return RedirectToAction(nameof(Details), new { title = MovieTitle });
        }
    }
}
