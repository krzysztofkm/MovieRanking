using MovieRatingApplication.Interfaces;
using MovieRatingApplication.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRatingTests.Unit.Mocks
{
    class MovieRatingRepositoryMock : IMovieRatingRepository
    {
        public void Add(MovieRating entity)
        {
            //Do nothing
        }

        public List<MovieRating> Get(string title)
        {
            if (title == "abc")
                return new List<MovieRating>()
                {
                     new MovieRating()
                     {
                         Id = 1,
                         Title = "abc",
                         Rate = 10
                     },
                     new MovieRating(){
                         Id = 1,
                         Title = "abc",
                         Rate = 10
                     }
                };
            else
                return null;
        }
    }
}
