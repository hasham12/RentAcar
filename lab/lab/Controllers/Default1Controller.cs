using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab.Controllers
{
    public class Default1Controller : Controller
    {
        private TestDBEntities db = new TestDBEntities();

        //
        // GET: /Default1/

        public ActionResult Index()
        {
            return View(db.labtasks.ToList());
        }

        //
        // GET: /Default1/Details/5

        public ActionResult Details(int id = 0)
        {
            labtask labtask = db.labtasks.Find(id);
            if (labtask == null)
            {
                return HttpNotFound();
            }
            return View(labtask);
        }

        //
        // GET: /Default1/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Default1/Create

        [HttpPost]
        public ActionResult Create(labtask labtask)
        {
            if (ModelState.IsValid)
            {
                db.labtasks.Add(labtask);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(labtask);
        }

        //
        // GET: /Default1/Edit/5

        public ActionResult Edit(int id = 0)
        {
            labtask labtask = db.labtasks.Find(id);
            if (labtask == null)
            {
                return HttpNotFound();
            }
            return View(labtask);
        }

        //
        // POST: /Default1/Edit/5

        [HttpPost]
        public ActionResult Edit(labtask labtask)
        {
            if (ModelState.IsValid)
            {
                db.Entry(labtask).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(labtask);
        }

        //
        // GET: /Default1/Delete/5

        public ActionResult Delete(int id = 0)
        {
            labtask labtask = db.labtasks.Find(id);
            if (labtask == null)
            {
                return HttpNotFound();
            }
            return View(labtask);
        }

        //
        // POST: /Default1/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            labtask labtask = db.labtasks.Find(id);
            db.labtasks.Remove(labtask);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}