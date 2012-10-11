﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GlobalErrorFilterDemo.Controllers
{
    public class ErrorController : Controller
    {
        public ActionResult HttpError()
        {
            return View("Error");
        }
        public ActionResult NotFound()
        {
            return View();
        }
        public ActionResult Index()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
