using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using A_Hand_2.Models;
using Microsoft.AspNet.Identity;

namespace A_Hand_2.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private ApplicationDbContext _Context;

        public HomeController()
        {
            _Context = new ApplicationDbContext();
        }

        public ActionResult Index()
        {
            var currentUserId = User.Identity.GetUserId();
            // var customerInfo = _Context.Customers.SingleOrDefault(p => p.UserId = currentUserId);

            //if (customerInfo == null)
            //{
            //    customerInfo = _Context.Customers.Create();



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