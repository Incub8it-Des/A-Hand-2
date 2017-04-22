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

        public ActionResult AskTask_1()
        {
            //var askTaskViewModel = new AskTaskViewModel();

            //var askTask = _Context.AskTasks.Include(c => c.BasicDescription).ToList();
            //var askTask = new AskTask() {BasicDescription = "Davie"};

            var askTask = _Context.AskTasks.SingleOrDefault(c => c.Id == 5);



            return View(askTask);
        }

        public ActionResult Save(AskTask askTask)

        {
            var askTaskInDb = _Context.AskTasks.Single(c => c.Id == 5);

            askTaskInDb.BasicDescription = askTask.BasicDescription;

            _Context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}