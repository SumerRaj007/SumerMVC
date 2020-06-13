using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SumerRaj.Models;
using SumerRaj.ViewModel;

namespace SumerRaj.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            var getMovie = GetMovies();
            return View(getMovie);
        }

        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };

            //return Content("Hello world");
            // return HttpNotFound();
            //return new EmptyResult();
            // return RedirectToAction("Index", "Home");
            //return RedirectToAction("Index", "Home", new { page = 1, sortby = "Name" });
            //ViewData["RandomMovie"] = movie;
            //ViewBag.Movie = movie;
            var customers = new List<Customer>
            {
               new Customer{ Name="Customer 1"},
               new Customer{ Name="Customer 2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
            //var viewResult = new ViewResult();
            //viewResult.ViewData.Model
            return View(viewModel);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie{Id=1,Name="Fast&Furious"},
                new Movie{Id=2,Name="MIssion Imposible"}
            };
        }

        //public ActionResult Edit(int id)
        //{
        //    return Content("Id= "  +id);
        //}

        //public ActionResult Index(int? pageIndex,string sortBy)
        //{
        //    if (!pageIndex.HasValue)
        //        pageIndex = 1;
        //    if (string.IsNullOrEmpty(sortBy))
        //        sortBy = "Name";
        //    return Content(String.Format("PageIndex={0}&sortBy={1}", pageIndex, sortBy));
        //}
        //[Route("Movies/ByReleaseDate/{year}/{month:regex(\\d{4}):range(1,12)}")]
        //public ActionResult ByReleaseDate(int year,int month)
        //{
        //    return Content(year+ "/" + month);
        //}

    }
}