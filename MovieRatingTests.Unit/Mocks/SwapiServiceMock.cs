using MovieRatingApplication.Interfaces;
using MovieRatingApplication.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRatingTests.Unit.Mocks
{
    class SwapiServiceMock : ISwapiService
    {
        public List<MovieViewModel> GetAllMovies()
        {
            return new List<MovieViewModel>()
            {
                new MovieViewModel()
                {
                    Title = "abc"
                },
                new MovieViewModel()
                {
                    Title = "xyz"
                }
            };
            
        }

        public MovieDetailsViewModel GetMovie(string title)
        {
            if (title == "abc")
                return new MovieDetailsViewModel()
                {

                    Title = "abc",
                    EpisodId = 1,
                    OpeningCrawl = "abc",
                    Director = "abc",
                    ReleaseDate = new DateTime(1800 - 01 - 01),
                    Rating = 10
                };
            else
                return null;
        }
    }
}
