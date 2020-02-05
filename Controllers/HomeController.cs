using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SaveOurSpecies.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Save Our Species (SOS)";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Save Our Species (SOS)";

            return View();
        }
    }
}