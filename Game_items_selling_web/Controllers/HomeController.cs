﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Game_items_selling_web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Administrator()
        {
            return View();
        }

        public ActionResult Trader()
        {
            return View();
        }

        public ActionResult Developer()
        {
            return View();
        }

    }
}