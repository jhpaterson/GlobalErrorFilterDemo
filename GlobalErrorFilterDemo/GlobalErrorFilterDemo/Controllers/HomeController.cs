using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GlobalErrorFilterDemo.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Argument()
        {
            throw new ArgumentException();
        }

        public ActionResult NotImplemented()
        {
            throw new NotImplementedException();
        }

    }
}
