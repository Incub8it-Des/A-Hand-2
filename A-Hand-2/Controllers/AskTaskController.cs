using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using A_Hand_2.Models;
using A_Hand_2.ViewModels;
using Microsoft.AspNet.Identity;

namespace A_Hand_2.Controllers
{
    public class AskTaskController : Controller
    {
        private ApplicationDbContext _Context;

        public AskTaskController()
        {
            _Context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _Context.Dispose();
        }


        public ActionResult Save(AskTask askTask)

        {
            var askTaskInDb = _Context.AskTasks.Single(c => c.Id == 5);

            askTaskInDb.BasicDescription = askTask.BasicDescription;

            _Context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

        public ActionResult New()
        {
            //var viewModel = new AskTask();
            var taskTypes = _Context.TaskTypes.ToList();

            var viewModel = new AskTaskViewModel()
                {
                    TaskTypes = taskTypes
                };

            return View(viewModel);
        }

        public ActionResult Create(AskTask askTask)
        {
            askTask.CustomerId = 5;
            _Context.AskTasks.Add(askTask);
            _Context.SaveChanges();

            return RedirectToAction("Index", "Home");

        }

        public ActionResult ShowCascade()
        {
            var user = _Context.Users.Include(U => U.Customers);
            //var cust = _Context.Users.;
            var cascadeModel = new CascadeViewModel()
            {
             User   = user
             //Customers = cust
            };

            return View(cascadeModel);
        }

        public ActionResult ShowCustomers()
        {
            var custList = _Context.Customers;
            var customers = new CustomerViewModel()
            {
                Customers = custList
            };
            return View(customers);
        }
    }
}