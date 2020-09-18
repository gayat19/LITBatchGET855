using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UnderstandingSecurityProject.Models;

namespace UnderstandingSecurityProject.Controllers
{
    [Authorize]//Filter in controller level
    [HandleError]
    public class ProductController : Controller
    {
        // GET: Product
       // [Authorize]//Filter
        public ActionResult DisplayProducts()
        {
            List<Products> products = new List<Products>()
            {
                new Products()
                {
                    Id=101,Name="Pen",Price=12.5f
                },
                new Products()
                {
                    Id=102,Name="Pencil",Price=10.0f
                },
                new Products()
                {
                    Id=103,Name="Scale",Price=25.5f
                }
            };
            return View(products);
        }
      
        [HandleError(ExceptionType =typeof(DivideByZeroException),View ="DBZError")]
        [AllowAnonymous]//Bypass authentocation only for this action method
        public ActionResult AnotherProducts()
        {
            int num1 = 0, num2 = 10, result = 0;
            result = num2 / num1;
            //throw new Exception();
            return View();
        }
    }
}