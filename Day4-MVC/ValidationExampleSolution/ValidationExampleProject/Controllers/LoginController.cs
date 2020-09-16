using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ValidationExampleProject.Models;

namespace ValidationExampleProject.Controllers
{
    public class LoginController : Controller
    {
        dbDiscShopEntities dse = new dbDiscShopEntities();
        // GET: Login
        public ActionResult UserLogin()
        {
            if(TempData["username"]!= null)
            {
                user user1 = new user();
                //user1.username = TempData["username"].ToString();//Data will be empty after reading
                user1.username = TempData.Peek("username").ToString();//Data will stay put coz we are peeking
                //TempData.Keep("username");
                return View(user1);
            }
            ViewBag.Error = "";
            return View();
        }
        [HttpPost]
        public ActionResult UserLogin(user user)
        {
            if (ModelState.IsValid == false)
                return View();
            proc_LoginCheck_Result userdata = null;
            try
            {
               userdata = dse.proc_LoginCheck(user.username, user.password).First();
            }
            catch (Exception)
            {
                ViewBag.Error = "Invalid username or password";
                return View();
            }
            return RedirectToAction("UserHome",userdata);
        }

        public ActionResult UserHome(proc_LoginCheck_Result user)
        {
            return View(user);
        }
        public ActionResult Register()
        {
            UserRegistration userRegister = new UserRegistration();
            userRegister.roleList = new List<UserRole>()
            {
                new UserRole("user","user"),
                new UserRole("admin","admin")
            };
            return View(userRegister);
        }
        [HttpPost]
        public ActionResult Register(UserRegistration userRegister)
        {
            if(!ModelState.IsValid)
                return View();
            else
            {
                try
                {
                    dse.proc_register_user(userRegister.username, userRegister.password,userRegister.name, 
                        userRegister.age, userRegister.role);
                    TempData["username"] = userRegister.username;
                }
                catch (Exception e)
                {
                    return RedirectToAction("Register");

                }
                return RedirectToAction("UserLogin");
            }
        }
    }
}