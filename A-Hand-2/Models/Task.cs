using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace A_Hand_2.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string BasicDescription { get; set; }
        public string FurtherDetail { get; set; }
        public double MaxValue { get; set; }
        public DateTime TaskStartDate { get; set; }
    }
}