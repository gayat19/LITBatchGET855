using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using UnderstandingSecurityProject.Models;

namespace UnderstandingSecurityProject.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult UserLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UserLogin(User user)
        {
            if(user.Username.Length==4 && user.Password=="1234")
            {
                TempData["username"] = user.Username;
                FormsAuthentication.SetAuthCookie(user.Username,false);
                return RedirectToAction("DisplayProducts", "Product");  
            }
            else
            {
                ViewBag.ErrorMessage = "Invalid username or password";
                return View();
            }
            
        }
    }
}