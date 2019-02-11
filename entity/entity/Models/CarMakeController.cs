using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace entity.Models
{
    public class CarMakeController : Controller
    {
        private CarRentalEntities db = new CarRentalEntities();

        //
        // GET: /CarMake/

        public ActionResult Index()
        {
            return View(db.CarMakes.ToList());
        }

        //
        // GET: /CarMake/Details/5

        public ActionResult Details(int id = 0)
        {
            CarMake carmake = db.CarMakes.Find(id);
            if (carmake == null)
            {
                return HttpNotFound();
            }
            return View(carmake);
        }

        //
        // GET: /CarMake/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /CarMake/Create

        [HttpPost]
        public ActionResult Create(CarMake carmake)
        {
            if (ModelState.IsValid)
            {
                db.CarMakes.Add(carmake);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(carmake);
        }

        //
        // GET: /CarMake/Edit/5

        public ActionResult Edit(int id = 0)
        {
            CarMake carmake = db.CarMakes.Find(id);
            if (carmake == null)
            {
                return HttpNotFound();
            }
            return View(carmake);
        }

        //
        // POST: /CarMake/Edit/5

        [HttpPost]
        public ActionResult Edit(CarMake carmake)
        {
            if (ModelState.IsValid)
            {
                db.Entry(carmake).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(carmake);
        }

        //
        // GET: /CarMake/Delete/5

        public ActionResult Delete(int id = 0)
        {
            CarMake carmake = db.CarMakes.Find(id);
            if (carmake == null)
            {
                return HttpNotFound();
            }
            return View(carmake);
        }

        //
        // POST: /CarMake/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            CarMake carmake = db.CarMakes.Find(id);
            db.CarMakes.Remove(carmake);
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