using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using A_Hand_2.Models;

namespace A_Hand_2.Controllers
{
    public class AJAXController : Controller
    {

        private ApplicationDbContext _Context;

        public AJAXController()
        {
            _Context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _Context.Dispose();
        }


        // GET: AJAX
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public JsonResult AutoComplete(string prefix)
        {

            var customers = (from customer in _Context.Villages
                             where customer.VillageName.StartsWith(prefix)
                             select new
                             {
                                 label = customer.VillageName,
                                 val = customer.Id
                             }).ToList();

            return Json(customers);
        }

        [HttpPost]
        public ActionResult Index(string CustomerName, string CustomerId)
        {
            ViewBag.Message = "CustomerName: " + CustomerName + " CustomerId: " + CustomerId;
            return View();
        }
    }
}