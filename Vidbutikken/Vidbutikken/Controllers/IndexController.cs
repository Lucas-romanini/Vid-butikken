using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Vidbutikken.Controllers
{
    public class IndexController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Butikken()
        {
            return View();
        }
        public ActionResult Butikken_grid()
        {
            return View();
        }
        public ActionResult Kontakt()
        {
            return View();
        }
        public ActionResult laesmere()
        {
            return View();
        }
        public ActionResult omos()
        {
            return View();
        }
    }
}