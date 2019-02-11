using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab.Controllers
{
    public class loginController : Controller
    {
        private TestDBEntities db = new TestDBEntities();

        //
        // GET: /login/

        public ActionResult Index()
        {
            return View(db.logininfoes.ToList());
        }

        //
        // GET: /login/Details/5

        public ActionResult Details(string id = null)
        {
            logininfo logininfo = db.logininfoes.Find(id);
            if (logininfo == null)
            {
                return HttpNotFound();
            }
            return View(logininfo);
        }

        //
        // GET: /login/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /login/Create

        [HttpPost]
        public ActionResult Create(logininfo logininfo)
        {
            if (ModelState.IsValid)
            {
                db.logininfoes.Add(logininfo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(logininfo);
        }

        //
        // GET: /login/Edit/5

        public ActionResult Edit(string id = null)
        {
            logininfo logininfo = db.logininfoes.Find(id);
            if (logininfo == null)
            {
                return HttpNotFound();
            }
            return View(logininfo);
        }

        //
        // POST: /login/Edit/5

        [HttpPost]
        public ActionResult Edit(logininfo logininfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(logininfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(logininfo);
        }

        //
        // GET: /login/Delete/5

        public ActionResult Delete(string id = null)
        {
            logininfo logininfo = db.logininfoes.Find(id);
            if (logininfo == null)
            {
                return HttpNotFound();
            }
            return View(logininfo);
        }

        //
        // POST: /login/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(string id)
        {
            logininfo logininfo = db.logininfoes.Find(id);
            db.logininfoes.Remove(logininfo);
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