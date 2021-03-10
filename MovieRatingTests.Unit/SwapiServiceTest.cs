using MovieRatingApplication.Services;
using NUnit.Framework;

namespace MovieRatingTests.Unit
{
    /// <summary>
    /// More like a integration test
    /// </summary>
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetAllMovies_NoCondition_NotAmptyResult()
        {
            var service = new SwapiService();
            var movies = service.GetAllMovies();
            Assert.Greater(movies.Count, 0);
        }

        [Test]
        public void GetMovie_ForTile_NoThrowException()
        {
            var service = new SwapiService();
            var movie = service.GetMovie("");
            Assert.Pass();
        }
    }
}