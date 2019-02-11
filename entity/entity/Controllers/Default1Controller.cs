using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace entity.Controllers
{
    public class Default1Controller : Controller
    {
        private CarRentalEntities db = new CarRentalEntities();

        //
        // GET: /Default1/

        public ActionResult Index()
        {
            var carinfoes = db.CarInfoes.Include(c => c.CarMake);
            return View(carinfoes.ToList());
        }

        //
        // GET: /Default1/Details/5

        public ActionResult Details(int id = 0)
        {
            CarInfo carinfo = db.CarInfoes.Find(id);
            if (carinfo == null)
            {
                return HttpNotFound();
            }
            return View(carinfo);
        }

        //
        // GET: /Default1/Create

        public ActionResult Create()
        {
            ViewBag.carmakers = db.CarMakes;
            return View();
        }

        //
        // POST: /Default1/Create

        [HttpPost]
        public ActionResult Create(CarInfo carinfo)
        {
            if (ModelState.IsValid)
            {
                db.CarInfoes.Add(carinfo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MakeNameId = new SelectList(db.CarMakes, "MakeNameId", "MakeName", carinfo.MakeNameId);
            return View(carinfo);
        }

        //
        // GET: /Default1/Edit/5

        public ActionResult Edit(int id = 0)
        {
            CarInfo carinfo = db.CarInfoes.Find(id);
            if (carinfo == null)
            {
                return HttpNotFound();
            }
            ViewBag.MakeNameId = new SelectList(db.CarMakes, "MakeNameId", "MakeName", carinfo.MakeNameId);
            return View(carinfo);
        }

        //
        // POST: /Default1/Edit/5

        [HttpPost]
        public ActionResult Edit(CarInfo carinfo)
        {
            db.Entry(carinfo).State = EntityState.Modified;
            db.SaveChanges();
            ViewBag.MakeNameId = new SelectList(db.CarMakes, "MakeNameId", "MakeName", carinfo.MakeNameId);
            return RedirectToAction("Index","Default1");
        }

        //
        // GET: /Default1/Delete/5

        public ActionResult Delete(int id = 0)
        {
            CarInfo carinfo = db.CarInfoes.Find(id);
            if (carinfo == null)
            {
                return HttpNotFound();
            }
            return View(carinfo);
        }

        //
        // POST: /Default1/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            CarInfo carinfo = db.CarInfoes.Find(id);
            db.CarInfoes.Remove(carinfo);
            db.SaveChanges();
            return RedirectToAction("Index","Default1");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}