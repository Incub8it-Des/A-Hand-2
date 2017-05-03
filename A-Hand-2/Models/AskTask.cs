using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace A_Hand_2.Models
{
    public class AskTask

    {
        //[Key, ForeignKey("ApplicationUser")]
        //public string ApplicationUserId { get; set; }

        public int Id { get; set; }

        [Display(Name = "Basic Task Description")]
        public string BasicDescription { get; set; }

        [Display(Name = "Further Details")]
        public string FurtherDetail { get; set; }

        public double? MaxValue { get; set; }
        public DateTime? TaskStartDate { get; set; }

        //public Customer Customer { get; set; }
        //public int CustomerId { get; set; }

        public int TaskTypeId { get; set; }
        public TaskType TaskType { get; set; }

        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }

    }
}