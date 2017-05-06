using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
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
        private ApplicationUser _applicationUser;

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
            //var string userID_Guid = 
            var askTaskInDb = _Context.AskTasks.Single(c => c.Id == 5);

            askTaskInDb.BasicDescription = askTask.BasicDescription;
            askTaskInDb.User = askTask.User;

            _Context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

        public ActionResult New()
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

        public ActionResult Create(AskTask asktask)
        {
            asktask.UserId = User.Identity.GetUserId();
            _Context.AskTasks.Add(asktask);
            _Context.SaveChanges();

            return RedirectToAction("Index", "Home");

        }

        //public ActionResult ShowCascade()
        //{
        //    var user = _Context.Users.Include(U => U.Customer);
        //    //var cust = _Context.Users.;
        //    var cascadeModel = new CascadeViewModel()
        //    {
        //        User = user
        //        //Customers = cust
        //    };

        //    return View(cascadeModel);
        //}

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
            var userList = new UserViewModel()
            {
                ApplicationUsers = _Context.Users.Include(at => at.AskTasks)
            };
            
            return View(userList);
        }

    }
}