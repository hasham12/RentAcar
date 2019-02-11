using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class infoController : Controller
    {
        //
        // GET: /info/
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(info i)
        {
            i.verify();
            return View();
        }

        [HttpGet]
        public ActionResult del()
        {
            return View();
        }


        [HttpPost]
        public ActionResult del(info i)
        {
            i.verify2();
            return View();
        }

        [HttpGet]
        public ActionResult logg()
        {
            return View();
        }

        [HttpPost]
        public ActionResult logg(login l)
        {
            if (l.log())
            {
                return RedirectToAction("Index"); 
            }

            return View();
            
        }


        [HttpGet]
        public ActionResult show()
        {
            info i = new info();
            

            return View(i.verify3().ToList());
 
        }
	}
}