using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using A_Hand_2.Models;
using A_Hand_2.ViewModels;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace A_Hand_2.Controllers
{
    [System.Runtime.InteropServices.Guid("C8CDBFCE-A4C1-4A8B-8983-21D5F3E1BD99")]
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
            askTaskInDb.User = askTask.User;

            _Context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

        public ActionResult New_Page_1()
        {
            var taskTypes = _Context.TaskTypes.ToList();
            var userId = User.Identity.GetUserId();

            var viewModel = new NewAskTaskViewModel()
            {
                AskTask = new AskTask(),
                TaskTypes = taskTypes,
                UserId = userId
            };

            return View(viewModel);
        }

        public ActionResult Save_Page_1(AskTask asktask)
        {
            asktask.UserId = User.Identity.GetUserId();
            asktask.TaskStatusId = 1;
            DateTime dateNow = DateTime.Now.AddHours(-1);
            asktask.LoggedOn = dateNow;

            _Context.AskTasks.Add(asktask);

            _Context.SaveChanges();

            int NewId = asktask.Id;

            var askTaskToPass = _Context.AskTasks.SingleOrDefault(at => at.Id == NewId);

            return View("New_Page_2",askTaskToPass);

        }

        public ActionResult Create(AskTask asktask)
        {

            var customerInDb = _Context.AskTasks.Single(c => c.Id == asktask.Id);

            customerInDb.MaxValue = asktask.MaxValue;
            customerInDb.TaskStartDate = asktask.TaskStartDate;
            customerInDb.TaskTown = asktask.TaskTown;

            _Context.SaveChanges();

            return RedirectToAction("Index", "Home");

        }

        public ActionResult ShowCascade()
        {
            var user = _Context.Users.Include(u => u.Customer);
            
            var cascadeModel = new CascadeViewModel()
            {
                User = user
            };

            return View(cascadeModel);
        }

        public ActionResult ShowCustomers()
        {
            var custList = _Context.Customers;
            var guid = User.Identity.GetUserId();
            var customers = new CustomerViewModel()
            {
                Customers = custList,
                GUID = guid
            };
            return View(customers);
        }

        public ActionResult ShowUser()
        {

            var appUser = _Context.Users.Include(u => u.AskTasks).Include(u => u.Customer).Include(u => u.AskTasks.Select(t => t.TaskType));

            appUser = appUser.OrderBy(ApplicationUser => ApplicationUser.Customer.DisplayName);

            return View(appUser);

        }

        public ActionResult ShowUserAskTask()
        {
            var currUser = User.Identity.GetUserId();
            var appUser = _Context.Users.Include(u => u.AskTasks).Include(u => u.Customer).Include(u => u.AskTasks.Select(t => t.TaskType)).Where( u => u.Id == currUser);
            //var appUser = _Context.Users.Include(u => u.AskTasks).Include(u => u.Customer).Include(u => u.AskTasks.Select(t => t.TaskType));

            appUser = appUser.OrderBy(ApplicationUser => ApplicationUser.Customer.DisplayName);

            return View("ShowUser", appUser);

        }

    }
}