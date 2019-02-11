using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace entity.Controllers
{
    public class PickLocationController : Controller
    {
        private CarRentalEntities db = new CarRentalEntities();

        //
        // GET: /PickLocation/

        public ActionResult Index()
        {
            return View(db.PickLocations.ToList());
        }

        //
        // GET: /PickLocation/Details/5

        public ActionResult Details(int id = 0)
        {
            PickLocation picklocation = db.PickLocations.Find(id);
            if (picklocation == null)
            {
                return HttpNotFound();
            }
            return View(picklocation);
        }

        //
        // GET: /PickLocation/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /PickLocation/Create

        [HttpPost]
        public ActionResult Create(PickLocation picklocation)
        {
            if (ModelState.IsValid)
            {
                db.PickLocations.Add(picklocation);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(picklocation);
        }

        //
        // GET: /PickLocation/Edit/5

        public ActionResult Edit(int id = 0)
        {
            PickLocation picklocation = db.PickLocations.Find(id);
            if (picklocation == null)
            {
                return HttpNotFound();
            }
            return View(picklocation);
        }

        //
        // POST: /PickLocation/Edit/5

        [HttpPost]
        public ActionResult Edit(PickLocation picklocation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(picklocation).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(picklocation);
        }

        //
        // GET: /PickLocation/Delete/5

        public ActionResult Delete(int id = 0)
        {
            PickLocation picklocation = db.PickLocations.Find(id);
            if (picklocation == null)
            {
                return HttpNotFound();
            }
            return View(picklocation);
        }

        //
        // POST: /PickLocation/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            PickLocation picklocation = db.PickLocations.Find(id);
            db.PickLocations.Remove(picklocation);
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