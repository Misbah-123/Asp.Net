using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DatabaseFirst.Models;

namespace DatabaseFirst.Controllers
{
    public class WatchesController : Controller
    {
        private Watchescontext db = new Watchescontext();

        // GET: Watches
        public ActionResult Index()
        {
            return View(db.Retail.ToList());
        }

        // GET: Watches/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Watches watches = db.Retail.Find(id);
            if (watches == null)
            {
                return HttpNotFound();
            }
            return View(watches);
        }

        // GET: Watches/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Watches/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,name,price")] Watches watches)
        {
            if (ModelState.IsValid)
            {
                db.Retail.Add(watches);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(watches);
        }

        // GET: Watches/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Watches watches = db.Retail.Find(id);
            if (watches == null)
            {
                return HttpNotFound();
            }
            return View(watches);
        }

        // POST: Watches/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,name,price")] Watches watches)
        {
            if (ModelState.IsValid)
            {
                db.Entry(watches).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(watches);
        }

        // GET: Watches/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Watches watches = db.Retail.Find(id);
            if (watches == null)
            {
                return HttpNotFound();
            }
            return View(watches);
        }

        // POST: Watches/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Watches watches = db.Retail.Find(id);
            db.Retail.Remove(watches);
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
