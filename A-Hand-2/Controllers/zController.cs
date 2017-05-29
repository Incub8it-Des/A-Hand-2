using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace A_Hand_2.Controllers
{
    public class zController : Controller
    {
        // GET: z
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DatePick()
        {
            return View();
        }
    }
}