using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UnderstandingEFProject.Models;

namespace UnderstandingEFProject.Controllers
{
    public class SampleController : Controller
    {
        NorthwindEntities nwentities = new NorthwindEntities();
        // GET: Sample
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(tblSample sample)
        {
            //Insert into tblSample values(101,'Blah')
            nwentities.tblSamples.Add(sample);//Will add the object to the collection locally
            nwentities.SaveChanges();//Will update the database
            return View();
        }
    }
}