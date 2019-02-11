using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace entity.Controllers
{
    public class CustomerController : Controller
    {
        private CarRentalEntities db = new CarRentalEntities();

        //
        // GET: /Customer/
        public ActionResult CreateType()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateType(CustomerType type)
        {
            db.CustomerTypes.Add(type);
            db.SaveChanges();
            return RedirectToAction("Create");
        }
        public ActionResult Index()
        {
            var customerinfoes = db.CustomerInfoes.Include(c => c.CustomerType);
            return View(customerinfoes.ToList());
        }

        //
        // GET: /Customer/Details/5

        public ActionResult Details(int id = 0)
        {
            CustomerInfo customerinfo = db.CustomerInfoes.Find(id);
            if (customerinfo == null)
            {
                return HttpNotFound();
            }
            return View(customerinfo);
        }

        //
        // GET: /Customer/Create

        public ActionResult Create()
        {
            ViewBag.CustTypeId =  db.CustomerTypes;
            return View();
        }

        //
        // POST: /Customer/Create

        [HttpPost]
        public ActionResult Create(CustomerInfo customerinfo)
        {
            if (ModelState.IsValid)
            {
                db.CustomerInfoes.Add(customerinfo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CustTypeId = new SelectList(db.CustomerTypes, "CustTypeId", "CustTypeName", customerinfo.CustTypeId);
            return View(customerinfo);
        }

        //
        // GET: /Customer/Edit/5

        public ActionResult Edit(int id = 0)
        {
            CustomerInfo customerinfo = db.CustomerInfoes.Find(id);
            if (customerinfo == null)
            {
                return HttpNotFound();
            }
            ViewBag.CustTypeId = new SelectList(db.CustomerTypes, "CustTypeId", "CustTypeName", customerinfo.CustTypeId);
            return View(customerinfo);
        }

        //
        // POST: /Customer/Edit/5

        [HttpPost]
        public ActionResult Edit(CustomerInfo customerinfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(customerinfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CustTypeId = new SelectList(db.CustomerTypes, "CustTypeId", "CustTypeName", customerinfo.CustTypeId);
            return View(customerinfo);
        }

        //
        // GET: /Customer/Delete/5

        public ActionResult Delete(int id = 0)
        {
            CustomerInfo customerinfo = db.CustomerInfoes.Find(id);
            if (customerinfo == null)
            {
                return HttpNotFound();
            }
            return View(customerinfo);
        }

        //
        // POST: /Customer/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            CustomerInfo customerinfo = db.CustomerInfoes.Find(id);
            db.CustomerInfoes.Remove(customerinfo);
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