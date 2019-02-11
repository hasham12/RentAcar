using log.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace log.Controllers
{
    public class infoController : Controller
    {
        //
        // GET: /info/

        public ActionResult Index()
        {
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
                return RedirectToAction("logg");
            }

            return View();

        }
    }
}
