using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MoreOnMVCandEFinProject.Models;

namespace MoreOnMVCandEFinProject.Controllers
{
    public class moviesController : Controller
    {
        // GET: movies
        dbDiscShopEntities dse = new dbDiscShopEntities();
        public ActionResult Index()
        {

            return View(dse.movies);
        }
    }
}