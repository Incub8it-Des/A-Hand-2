using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using A_Hand_2.Models;
using A_Hand_2.ViewModels;

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

            return RedirectToAction("Index", "Home");

        }
    }
}