﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASfdg dfg dfP.NET MVC!";
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
