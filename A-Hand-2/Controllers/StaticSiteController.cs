﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace A_Hand_2.Controllers
{
    [AllowAnonymous]
    public class StaticSiteController : Controller
    {
        
        public ActionResult HowItWorks()
        {
            return (View());
        }

        public ActionResult Testimonials()
        {
            return (View());
        }

        public ActionResult BecomeAHand()
        {
            return (View());
        }
    }
}