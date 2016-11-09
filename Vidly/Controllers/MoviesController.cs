using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.Models.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {

        // GET: Movies
        public ActionResult Index()
        {
            try
            {
                var movies = new List<Movie> {
                    new Movie { Id = 1, Name = "Shrek !" },
                    new Movie { Id = 2, Name = "Wall e"}
                };
                return View(movies);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }                

        // GET: Movies/Random
        public ActionResult Random()
        {
            Movie movie = new Movie() { Name = "Shrek!"};
            var customers = new List<Customer> {
                new Customer { Id = 1, Name = "Peter" },
                new Customer { Id = 1, Name = "Jane" }

            };
            var randomMovieVm = new RandomMovieViewModel {
                Movie = movie,
                Customers = customers
            };
            return View(randomMovieVm);
        }
    }
}