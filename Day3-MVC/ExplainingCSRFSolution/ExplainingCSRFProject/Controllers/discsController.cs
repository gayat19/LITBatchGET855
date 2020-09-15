using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ExplainingCSRFProject.Models;

namespace ExplainingCSRFProject.Controllers
{
    public class discsController : Controller
    {
        private dbDiscShopEntities db = new dbDiscShopEntities();

        // GET: discs
        public ActionResult Index()
        {
            var discs = db.discs.Include(d => d.movy);
            return View(discs.ToList());
        }

        // GET: discs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            disc disc = db.discs.Find(id);
            if (disc == null)
            {
                return HttpNotFound();
            }
            return View(disc);
        }

        // GET: discs/Create
        public ActionResult Create()
        {
            ViewBag.movie_id = new SelectList(db.movies, "id", "name");
            return View();
        }

        // POST: discs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,movie_id,rental_cost")] disc disc)
        {
            if (ModelState.IsValid)
            {
                db.discs.Add(disc);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.movie_id = new SelectList(db.movies, "id", "name", disc.movie_id);
            return View(disc);
        }

        // GET: discs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            disc disc = db.discs.Find(id);
            if (disc == null)
            {
                return HttpNotFound();
            }
            ViewBag.movie_id = new SelectList(db.movies, "id", "name", disc.movie_id);
            return View(disc);
        }

        // POST: discs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,movie_id,rental_cost")] disc disc)
        {
            if (ModelState.IsValid)
            {
                db.Entry(disc).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.movie_id = new SelectList(db.movies, "id", "name", disc.movie_id);
            return View(disc);
        }

        // GET: discs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            disc disc = db.discs.Find(id);
            if (disc == null)
            {
                return HttpNotFound();
            }
            return View(disc);
        }

        // POST: discs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            disc disc = db.discs.Find(id);
            db.discs.Remove(disc);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
