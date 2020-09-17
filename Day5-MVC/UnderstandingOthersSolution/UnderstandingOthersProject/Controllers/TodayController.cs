using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UnderstandingOthersProject.Controllers
{
    public class TodayController : Controller
    {
        // GET: Today
        public ActionResult Index()
        {
            return View();
        }

       [ChildActionOnly]
        public ActionResult Check()
        {
            ViewBag.FromCheck = "From Check....";
            return View();
        }
    }
}