using System.Web.Mvc;
using MVC_Razor.Models;

namespace MVC_Razor.Controllers
{
    
    public class JobDetailsController : Controller
    {    
        [HttpGet]
        // GET: JobDetails
        public ActionResult Info()
        {
            JobInfo ji = new JobInfo {Description = "Hello"};
            return View(ji);
        }
        
        [HttpPost]
        // GET: JobDetails
        public ActionResult Info(JobInfo info)
        {
           return RedirectToAction("Confirm");
        }

        public ActionResult Confirm()
        {
            return View();
        }
    }
}