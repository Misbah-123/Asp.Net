using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using data_annotation.Models;

namespace data_annotation.Controllers
{
    public class MakeupsController : Controller
    {
        private Makeupcontext db = new Makeupcontext();

        // GET: Makeups
        public ActionResult Index()
        {
            return View(db.Make.ToList());
        }

        // GET: Makeups/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Makeup makeup = db.Make.Find(id);
            if (makeup == null)
            {
                return HttpNotFound();
            }
            return View(makeup);
        }

        // GET: Makeups/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Makeups/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Email,price")] Makeup makeup)
        {
            if (ModelState.IsValid)
            {
                db.Make.Add(makeup);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(makeup);
        }

        // GET: Makeups/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Makeup makeup = db.Make.Find(id);
            if (makeup == null)
            {
                return HttpNotFound();
            }
            return View(makeup);
        }

        // POST: Makeups/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Email,price")] Makeup makeup)
        {
            if (ModelState.IsValid)
            {
                db.Entry(makeup).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(makeup);
        }

        // GET: Makeups/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Makeup makeup = db.Make.Find(id);
            if (makeup == null)
            {
                return HttpNotFound();
            }
            return View(makeup);
        }

        // POST: Makeups/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Makeup makeup = db.Make.Find(id);
            db.Make.Remove(makeup);
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
