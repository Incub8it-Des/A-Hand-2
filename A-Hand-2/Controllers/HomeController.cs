using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace A_Hand_2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Everything you ever wanted to know about A Hand 2 Help!";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Here's how you can contact us:";

            return View();
        }
    }
}