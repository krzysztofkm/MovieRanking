using MovieRatingApplication.BusinessLogic;
using MovieRatingApplication.Interfaces;
using MovieRatingTests.Unit.Mocks;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRatingTests.Unit
{
    class MovieLogicTest
    {
        private ISwapiService _swapiProvider;
        private IMovieRatingRepository _dataRepository;

        [SetUp]
        public void Setup()
        {
            _swapiProvider = new SwapiServiceMock();
            _dataRepository = new MovieRatingRepositoryMock();
        }

        [Test]
        public void AddRate_WithTitleAndCorrectRate_Passed()
        {
            IMovieLogic logic = new MovieLogic(_swapiProvider, _dataRepository);
            var result = logic.AddRate("dasdas", 3);
            Assert.IsTrue(result);
        }

        [Test]
        public void AddRate_Equal10_Passed()
        {
            IMovieLogic logic = new MovieLogic(_swapiProvider, _dataRepository);
            var result = logic.AddRate("fdsjfds da", 10);
            Assert.IsTrue(result);
        }

        [Test]
        public void AddRate_Equal2_Passed()
        {
            IMovieLogic logic = new MovieLogic(_swapiProvider, _dataRepository);
            var result = logic.AddRate("two", 2);
            Assert.IsTrue(result);
        }

        [Test]
        public void AddRate_EmptyTitle_Failed()
        {
            IMovieLogic logic = new MovieLogic(_swapiProvider, _dataRepository);
            var result = logic.AddRate("", 122343431);
            Assert.IsFalse(result);
        }

        [Test]
        public void AddRate_RateBelow0_Failed()
        {
            IMovieLogic logic = new MovieLogic(_swapiProvider, _dataRepository);
            var result = logic.AddRate("fdsjfds da", -1);
            Assert.IsFalse(result);
        }

        [Test]
        public void AddRate_Rate0_Failed()
        {
            IMovieLogic logic = new MovieLogic(_swapiProvider, _dataRepository);
            var result = logic.AddRate("fdsjfds da", 0);
            Assert.IsFalse(result);
        }

        [Test]
        public void AddRate_Above10_Failed()
        {
            IMovieLogic logic = new MovieLogic(_swapiProvider, _dataRepository);
            var result = logic.AddRate("fdsjfds da", 11);
            Assert.IsFalse(result);
        }
    }
}
