using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UnderstandingCodeFirstProject.Models;

namespace UnderstandingCodeFirstProject.Controllers
{
    public class CreateController : Controller
    {
        // GET: Create
        public ActionResult Index()
        {
            FilmContext filmContext = new FilmContext();
            //Movie movie = new Movie();
            //movie.Name = "MI";
            //movie.Duration = 122.2f;
            //filmContext.Movies.Add(movie);
            //filmContext.SaveChanges();
            //Disc disc = new Disc();
            //disc.Cost = 12.3f;
            //disc.Movie = movie;
            //filmContext.Discs.Add(disc);
            //filmContext.SaveChanges();
            ViewBag.Message = "Done Creating";
            return View();
        }

        public ActionResult Another()
        {
            ViewBag.Message = "Another View";
            return View();
        }
    }
}