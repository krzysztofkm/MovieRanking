using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRatingApplication.Models
{
    /// <summary>
    /// ViewModel which keeps all movie informations. 
    /// The same model is to to swapi communication, therefore contains attributes which are used during deserialization
    /// TODO: separate model for swapi
    /// </summary>
    public class MovieDetailsViewModel
    {
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("episode_id")]
        public int EpisodId { get; set; }
        [JsonProperty("opening_crawl")]
        public string OpeningCrawl { get; set; }
        [JsonProperty("director")]
        public string Director { get; set; }
        [JsonProperty("producer")]
        public string Producer { get; set; }
        [JsonProperty("release_date")]
        public DateTime ReleaseDate { get; set; }
        public decimal Rating { get; set; }
    }
}