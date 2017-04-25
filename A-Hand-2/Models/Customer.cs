using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace A_Hand_2.Models
{
    public class Customer
    {
        [Key, ForeignKey("ApplicationUser")]
        public string ApplicationUserId { get; set; }

        //public int Id { get; set; }
        public string DisplayName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Address4 { get; set; }
        public string Postcode { get; set; }
        //public AskTask AskTask { get; set; }
        //public int AskTaskId { get; set; }

        
        public virtual ApplicationUser ApplicationUser{ get; set; }



    }
}