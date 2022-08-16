using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC_entity_.Models;

namespace MVC_entity_.Controllers
{
    public class ShoesController : Controller
    {
        private shoescontext db = new shoescontext();

        // GET: Shoes
        public ActionResult Index()
        {
            return View(db.tae.ToList());
        }

        // GET: Shoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Shoes shoes = db.tae.Find(id);
            if (shoes == null)
            {
                return HttpNotFound();
            }
            return View(shoes);
        }

        // GET: Shoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Shoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,brand,price")] Shoes shoes)
        {
            if (ModelState.IsValid)
            {
                db.tae.Add(shoes);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(shoes);
        }

        // GET: Shoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Shoes shoes = db.tae.Find(id);
            if (shoes == null)
            {
                return HttpNotFound();
            }
            return View(shoes);
        }

        // POST: Shoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,brand,price")] Shoes shoes)
        {
            if (ModelState.IsValid)
            {
                db.Entry(shoes).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(shoes);
        }

        // GET: Shoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Shoes shoes = db.tae.Find(id);
            if (shoes == null)
            {
                return HttpNotFound();
            }
            return View(shoes);
        }

        // POST: Shoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Shoes shoes = db.tae.Find(id);
            db.tae.Remove(shoes);
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
