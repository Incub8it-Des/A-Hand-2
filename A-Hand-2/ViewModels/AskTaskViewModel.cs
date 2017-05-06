using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using A_Hand_2.Models;

namespace A_Hand_2.ViewModels
{
    public class NewAskTaskViewModel
    {
        public IEnumerable<TaskType> TaskTypes { get; set; }
        public AskTask AskTask { get; set; }
        public string UserId { get; set; }
    }

    public class CascadeViewModel
    {
        public IEnumerable<ApplicationUser> User { get; set; }
        public IEnumerable<Customer> Customers { get; set; }
    }

    public class CustomerViewModel
    {
        public IEnumerable<Customer> Customers { get; set; }
        public string GUID { get; set; }
    }

    public class UserViewModel
    {
        public IEnumerable<ApplicationUser> ApplicationUsers { get; set; }

    }
}