using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVCApplication.Controllers
{
    public class FirstController : Controller
    {
        // GET: First
        public string MyFirstMethod()
        {
            return "<h1>Hello</h1>";
        }

        public ActionResult SecondMethod()
        {
            return View();
        }

        public ActionResult MyOwn()
        {
            return View();
        }
        public ActionResult PassDataViewWithViewBag()
        {
            ViewBag.Name = "Ramu";
            ViewBag.Something = "Nothing";
            return View();
        }
        public ActionResult PassDataViewWithViewData()
        {
            ViewData["Name"] = "Ramu";
            ViewData["Age"] = 20;
            return View();
        }
        public ActionResult ViewDatavsViewBag()
        {
            List<string> names = new List<string>();
            names.Add("Ramu");
            names.Add("Somu");
            names.Add("Bimu");
            names.Add("Lomu");
            ViewBag.users= names;
            ViewData["users"] = names;
            return View();
        }
    }
}