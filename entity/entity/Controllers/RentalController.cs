using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace entity.Controllers
{
    public class RentalController : Controller
    {
        private CarRentalEntities db = new CarRentalEntities();

        //
        // GET: /Rental/

        public ActionResult Index()
        {
            var rentals = db.Rentals.Include(r => r.CarInfo).Include(r => r.CustomerInfo).Include(r => r.DriverInfo).Include(r => r.PickLocation);
           // return View(rentals.ToList());
            return View(rentals.ToList());
        }

        //
        // GET: /Rental/Details/5

        public ActionResult Details(int id = 0)
        {
            Rental rental = db.Rentals.Find(id);
            if (rental == null)
            {
                return HttpNotFound();
            }
            return View(rental);
        }

        //
        // GET: /Rental/Create

        public ActionResult Create()
        {
            ViewBag.CarId = new SelectList(db.CarInfoes, "CarId", "CarModel");
            ViewBag.CustomerId = new SelectList(db.CustomerInfoes, "CustomerId", "CustomerName");
            ViewBag.DriverId = new SelectList(db.DriverInfoes, "DriverId", "DriverName");
            ViewBag.LocationId = new SelectList(db.PickLocations, "LocationId", "Country");
            return View();
        }

        //
        // POST: /Rental/Create

        [HttpPost]
        public ActionResult Create(Rental rental)
        {
            if (ModelState.IsValid)
            {
                db.Rentals.Add(rental);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CarId = new SelectList(db.CarInfoes, "CarId", "CarModel", rental.CarId);
            ViewBag.CustomerId = new SelectList(db.CustomerInfoes, "CustomerId", "CustomerName", rental.CustomerId);
            ViewBag.DriverId = new SelectList(db.DriverInfoes, "DriverId", "DriverName", rental.DriverId);
            ViewBag.LocationId = new SelectList(db.PickLocations, "LocationId", "Country", rental.LocationId);
            return View(rental);
        }

        //
        // GET: /Rental/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Rental rental = db.Rentals.Find(id);
            if (rental == null)
            {
                return HttpNotFound();
            }
            ViewBag.CarId = new SelectList(db.CarInfoes, "CarId", "CarModel", rental.CarId);
            ViewBag.CustomerId = new SelectList(db.CustomerInfoes, "CustomerId", "CustomerName", rental.CustomerId);
            ViewBag.DriverId = new SelectList(db.DriverInfoes, "DriverId", "DriverName", rental.DriverId);
            ViewBag.LocationId = new SelectList(db.PickLocations, "LocationId", "Country", rental.LocationId);
            return View(rental);
        }

        //
        // POST: /Rental/Edit/5

        [HttpPost]
        public ActionResult Edit(Rental rental)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rental).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CarId = new SelectList(db.CarInfoes, "CarId", "CarModel", rental.CarId);
            ViewBag.CustomerId = new SelectList(db.CustomerInfoes, "CustomerId", "CustomerName", rental.CustomerId);
            ViewBag.DriverId = new SelectList(db.DriverInfoes, "DriverId", "DriverName", rental.DriverId);
            ViewBag.LocationId = new SelectList(db.PickLocations, "LocationId", "Country", rental.LocationId);
            return View(rental);
        }

        //
        // GET: /Rental/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Rental rental = db.Rentals.Find(id);
            if (rental == null)
            {
                return HttpNotFound();
            }
            return View(rental);
        }

        //
        // POST: /Rental/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Rental rental = db.Rentals.Find(id);
            db.Rentals.Remove(rental);
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