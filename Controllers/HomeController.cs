using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace projet_net.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Front()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "";

            return View();
        }
        public ActionResult Service()
        {
            return View();
        }
        

    }
}