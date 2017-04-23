using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using A_Hand_2.Models;

namespace A_Hand_2.ViewModels
{
    public class AskTaskViewModel
    {
        public IEnumerable<TaskType> TaskTypes { get; set; }
        public AskTask AskTask {get; set;}
        //public int CustId {21}
    }
}