using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using First_ASP.NET_Project.Models;

namespace First_ASP.NET_Project.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Mission: Impossible!" };
            return View(movie);
        }
    }
}