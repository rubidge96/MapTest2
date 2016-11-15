using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MapTest.Models;

namespace MapTest.Controllers
{
    public class SubjectsController : Controller
    {
        private Test_dbEntities db = new Test_dbEntities();

        // GET: Subjects
        public ActionResult Index()
        {
            return View(db.Test2.ToList());
        }

        // GET: Subjects/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Test2 test2 = db.Test2.Find(id);
            if (test2 == null)
            {
                return HttpNotFound();
            }
            return View(test2);
        }

        // GET: Subjects/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Subjects/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Name,City,Lat,Long")] Test2 test2)
        {
            if (ModelState.IsValid)
            {
                db.Test2.Add(test2);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(test2);
        }

        // GET: Subjects/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Test2 test2 = db.Test2.Find(id);
            if (test2 == null)
            {
                return HttpNotFound();
            }
            return View(test2);
        }

        // POST: Subjects/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Name,City,Lat,Long")] Test2 test2)
        {
            if (ModelState.IsValid)
            {
                db.Entry(test2).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(test2);
        }

        // GET: Subjects/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Test2 test2 = db.Test2.Find(id);
            if (test2 == null)
            {
                return HttpNotFound();
            }
            return View(test2);
        }

        // POST: Subjects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Test2 test2 = db.Test2.Find(id);
            db.Test2.Remove(test2);
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
