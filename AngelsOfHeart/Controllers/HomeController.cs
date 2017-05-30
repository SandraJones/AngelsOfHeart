using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AngelsOfHeart.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
           // ViewBag.Title = "Home Page";

            return View();
        }
        public ActionResult Volunteer()
        {
            ViewBag.Message = "Volunteer Page";

            return View();
        }
        public ActionResult Donate()
        {
            ViewBag.Message = "Donate Page";

            return View();
        }
        public ActionResult Gallery()
        {
            ViewBag.Message = "Gallery Page";
            return View();
        }
    }
}
