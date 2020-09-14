using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EntriFrameworkExampleProject.Models;

namespace EntriFrameworkExampleProject.Controllers
{
    public class OrderController : Controller
    {
        NorthwindEntities nwe = new NorthwindEntities();
        // GET: Order
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DisplayAllOrder()
        {
            List<Order> orders = nwe.Orders.ToList();
            orders.Sort(new OrderSortWithShipCity());
            return View(orders);
        }

        public ActionResult Details(int id)
        {
            //LINQ with lambda
            Order order = nwe.Orders.Where(o => o.OrderID == id).First();
            return View(order);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Order order = nwe.Orders.Where(o => o.OrderID == id).First();
            return View(order);
        }
        [HttpPost]
        public ActionResult Edit(Order order)
        {
            //Order MyOrder = nwe.Orders.Where(o => o.OrderID == order.OrderID).First();
            nwe.Entry(order).State = System.Data.Entity.EntityState.Modified;
            nwe.SaveChanges();
            return RedirectToAction("DisplayAllOrder");
        }
    }
}