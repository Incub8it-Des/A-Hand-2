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
        public int Id { get; set; }

        [Display(Name = "Basic Task Description")]
        public string BasicDescription { get; set; }

        [Display(Name = "Further Details")]
        public string FurtherDetail { get; set; }

        [Display(Name = "Maximum I'm prepared to pay")]
        [Range(1, 1000, ErrorMessage = "Price must be between £1 and £1000")]
        [DataType(DataType.Currency)]
        public double? MaxValue { get; set; }

        [Display(Name = "I need this work doing on")]
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? TaskStartDate { get; set; }

        [Display(Name = "The work needs to be done in")]
        public string TaskTown { get; set; }

        public int? TaskTownId { get; set; }
    
        public DateTime? LoggedOn { get; set; }

        public int TaskTypeId { get; set; }
        public TaskType TaskType { get; set; }

        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }

        public int TaskStatusId { get; set; }
        public TaskStatus TaskStatus { get; set; }

    }
}