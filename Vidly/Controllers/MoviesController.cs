using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {

            var movie = new Movie() { Name = "Sherk!" };
            return View(movie);
            //return Content("Hello World");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "Name"});
        }

        public ActionResult Edit(int id)
        {
            // http://localhost:50194/Movies/edit/5
            // http://localhost:50194/Movies/edit?id=10
            return Content("id=" + id);
        }

        
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            // http://localhost:50194/Movies?pageIndex=5&sortBy=releaseDate
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (string.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";
            return Content(string.Format("pageIndex={0} & sort={1}", pageIndex, sortBy));
        }
    }
}