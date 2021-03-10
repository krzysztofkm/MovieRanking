using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRatingApplication.Models
{
    public class MovieRating
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public int Rate { get; set; }
    }
}
