using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace A_Hand_2.Models
{
    public class TaskType
    {
        public int Id { get; set; }

        [Display(Name = "List Under")]
        public string TaskDesc { get; set; }
    }
}