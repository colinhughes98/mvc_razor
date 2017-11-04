using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Razor.Models;

namespace MVC_Razor.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page. from git hub";
            var b = "from github - so there";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ColView()
        {
            var p = new PersonViewModel();
            p.PreviousJobs = new List<string> {"GBG", "bet36", "Amaze"};
            return View(p);
        }

    }
}