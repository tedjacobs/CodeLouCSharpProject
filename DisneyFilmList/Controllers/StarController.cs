using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DisneyFilmList.DAL;
using DisneyFilmList.Models;

namespace DisneyFilmList.Controllers
{
    public class StarController : Controller
    {
        private FilmListContext db = new FilmListContext();

        // GET: Star
        public ActionResult Index()
        {
            return View(db.Stars.ToList());
        }

        // GET: Star/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Star star = db.Stars.Find(id);
            if (star == null)
            {
                return HttpNotFound();
            }
            return View(star);
        }

        // GET: Star/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Star/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "StarID,Name")] Star star)
        {
            if (ModelState.IsValid)
            {
                db.Stars.Add(star);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(star);
        }

        // GET: Star/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Star star = db.Stars.Find(id);
            if (star == null)
            {
                return HttpNotFound();
            }
            return View(star);
        }

        // POST: Star/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "StarID,Name")] Star star)
        {
            if (ModelState.IsValid)
            {
                db.Entry(star).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(star);
        }

        // GET: Star/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Star star = db.Stars.Find(id);
            if (star == null)
            {
                return HttpNotFound();
            }
            return View(star);
        }

        // POST: Star/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Star star = db.Stars.Find(id);
            db.Stars.Remove(star);
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
