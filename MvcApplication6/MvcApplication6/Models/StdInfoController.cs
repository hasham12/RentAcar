using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication6.Models
{
    public class StdInfoController : Controller
    {
        private TestDBBEntities db = new TestDBBEntities();

        //
        // GET: /StdInfo/

        public ActionResult Index()
        {
            return View(db.labtask1.ToList());
        }

        //
        // GET: /StdInfo/Details/5

        public ActionResult Details(int id = 0)
        {
            labtask1 labtask1 = db.labtask1.Find(id);
            if (labtask1 == null)
            {
                return HttpNotFound();
            }
            return View(labtask1);
        }

        //
        // GET: /StdInfo/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /StdInfo/Create

        [HttpPost]
        public ActionResult Create(labtask1 labtask1)
        {
            if (ModelState.IsValid)
            {
                db.labtask1.Add(labtask1);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(labtask1);
        }

        //
        // GET: /StdInfo/Edit/5

        public ActionResult Edit(int id = 0)
        {
            labtask1 labtask1 = db.labtask1.Find(id);
            if (labtask1 == null)
            {
                return HttpNotFound();
            }
            return View(labtask1);
        }

        //
        // POST: /StdInfo/Edit/5

        [HttpPost]
        public ActionResult Edit(labtask1 labtask1)
        {
            if (ModelState.IsValid)
            {
                db.Entry(labtask1).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(labtask1);
        }

        //
        // GET: /StdInfo/Delete/5

        public ActionResult Delete(int id = 0)
        {
            labtask1 labtask1 = db.labtask1.Find(id);
            if (labtask1 == null)
            {
                return HttpNotFound();
            }
            return View(labtask1);
        }

        //
        // POST: /StdInfo/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            labtask1 labtask1 = db.labtask1.Find(id);
            db.labtask1.Remove(labtask1);
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