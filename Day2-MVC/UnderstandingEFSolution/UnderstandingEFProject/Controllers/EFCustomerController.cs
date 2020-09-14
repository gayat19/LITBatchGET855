using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UnderstandingEFProject.Models;

namespace UnderstandingEFProject.Controllers
{
    public class EFCustomerController : Controller
    {
        // GET: EFCustomer
        NorthwindEntities entities = new NorthwindEntities();
        public ActionResult Index()
        {
            return View(entities.Customers);
        }
    }
}