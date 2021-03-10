using MovieRatingApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRatingApplication.Services
{
    public class MoviesResultModel <T>
    {
        public List<T> Results { get; set; }
    }
}
