using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication6.Models;
using WebApplication6.ViewModels;
using System.Data.Entity;

namespace WebApplication6.Controllers
{
    public class MoviesController : Controller
    {

        private ApplicationDbContext _context;

        public MoviesController()
        {
            this._context = new ApplicationDbContext();
        }


        protected override void Dispose(bool disposing)
        {
            _context?.Dispose();
            base.Dispose(disposing);
        }

        // GET: Movies
        public ActionResult Index()
        {
            var movies = _context.Movies.Include(m => m.Genre).ToList();

            return View(movies);

        }

        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);

            if (movie == null)
                return HttpNotFound();

            return View(movie);
        }

        public ActionResult New()
        {
            var viewModel = new MovieFormViewModel
            {
                Genres = _context.Genres.ToList()
            };

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult New(Movie movie)
        {
            var movieInDb = _context.Movies.SingleOrDefault(m => m.Id == movie.Id);

            if (movieInDb == null)
            {
                _context.Movies.Add(movie);
                _context.SaveChanges();

                return RedirectToAction("Index", "Movies");
            }

            return View();
        }

        
       
    }
}