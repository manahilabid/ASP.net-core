using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace class_04.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.data = "View Bag Method";
            ViewBag["msg"] = "View bag object";
            TempData["message"] = "temp data object";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}