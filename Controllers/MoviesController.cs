using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        #region Preparing the database context
        private ApplicationDbContext _MoviesContext;

        public MoviesController()
        {
            _MoviesContext = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _MoviesContext.Dispose();
        }
        #endregion


        public ActionResult Index()
        {
            var movies = _MoviesContext.Movies.Include(m => m.Genre).ToList();

            return View(movies);
        }

        public ActionResult Details(int id)
        {
            var movie = _MoviesContext.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);

            if (movie == null)
                return HttpNotFound();

            return View(movie);
        }

        public ActionResult New()
        {
            var genres = _MoviesContext.Genres.ToList();
            var viewModel = new MoviesFormViewModel()
            {
                Genres = genres
            };

            return View("MoviesForm", viewModel);
        }

        public ActionResult Edit(int id)
        {
            var movie = _MoviesContext.Movies.SingleOrDefault(m => m.Id == id);

            if (movie == null)
                return HttpNotFound();

            var viewModel = new MoviesFormViewModel()
            {
                Genres = _MoviesContext.Genres.ToList(),
                Movie = movie
            };

            return View("MoviesForm", viewModel);

        }

        public ActionResult Save(Movie movie)
        {
            if (movie.Id == 0)
            {
                movie.DateAdded = DateTime.Now;
                _MoviesContext.Movies.Add(movie);
            }
            else
            {
                var movieInDb = _MoviesContext.Movies.Single(m => m.Id == movie.Id);

                movieInDb.Name = movie.Name;
                movieInDb.ReleaseDate = movie.ReleaseDate;
                movieInDb.Genre = movie.Genre;
                movieInDb.InStock = movie.InStock;
            }

            _MoviesContext.SaveChanges();

            return RedirectToAction("Index", "Movies");
        }


























        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            var Customers = new List<Customer>
            {
                new Customer { Name = "Custmoer 1"},
                new Customer { Name = "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = Customers
            };

            return View(viewModel);
        }

        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {

            return Content(year + "/" + month);
        }
    }
}
