using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace entity.Controllers
{
    public class DriverInfoController : Controller
    {
        private CarRentalEntities db = new CarRentalEntities();

        //
        // GET: /DriverInfo/

        public ActionResult Index()
        {
            return View(db.DriverInfoes.ToList());
        }

        //
        // GET: /DriverInfo/Details/5

        public ActionResult Details(int id = 0)
        {
            DriverInfo driverinfo = db.DriverInfoes.Find(id);
            if (driverinfo == null)
            {
                return HttpNotFound();
            }
            return View(driverinfo);
        }

        //
        // GET: /DriverInfo/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /DriverInfo/Create

        [HttpPost]
        public ActionResult Create(DriverInfo driverinfo)
        {
            if (ModelState.IsValid)
            {
                db.DriverInfoes.Add(driverinfo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(driverinfo);
        }

        //
        // GET: /DriverInfo/Edit/5

        public ActionResult Edit(int id = 0)
        {
            DriverInfo driverinfo = db.DriverInfoes.Find(id);
            if (driverinfo == null)
            {
                return HttpNotFound();
            }
            return View(driverinfo);
        }

        //
        // POST: /DriverInfo/Edit/5

        [HttpPost]
        public ActionResult Edit(DriverInfo driverinfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(driverinfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(driverinfo);
        }

        //
        // GET: /DriverInfo/Delete/5

        public ActionResult Delete(int id = 0)
        {
            DriverInfo driverinfo = db.DriverInfoes.Find(id);
            if (driverinfo == null)
            {
                return HttpNotFound();
            }
            return View(driverinfo);
        }

        //
        // POST: /DriverInfo/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            DriverInfo driverinfo = db.DriverInfoes.Find(id);
            db.DriverInfoes.Remove(driverinfo);
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