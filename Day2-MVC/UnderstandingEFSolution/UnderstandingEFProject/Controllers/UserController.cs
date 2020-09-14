using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UnderstandingEFProject.Models;

namespace UnderstandingEFProject.Controllers
{
    public class UserController : Controller
    {
        NorthwindEntities nwe = new NorthwindEntities();
        // GET: User
        public ActionResult Index()
        {
            return View(nwe.users);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(user user)
        {
            nwe.users.Add(user);
            nwe.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}