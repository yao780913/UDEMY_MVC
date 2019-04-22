using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Sherk!" };
            var customers = new List<Customer>
            {
                new Customer { Name = "Customer1"},
                new Customer { Name = "Customer2"}
            };

            var viewModel = new RandomMovieViewＭodel
            {
                Movie = movie,
                Customers = customers
            };

            //不建議使用 ViewData & ViewBag !!
            //ViewData["Movie"] = movie;
            //ViewBag.Movie = movie;

            return View(viewModel);
        }
    }
}