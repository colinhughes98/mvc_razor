using System.Web;
using System.Web.Mvc;
using MVC_Razor.Models;

namespace MVC_Razor.Controllers
{
    [RoutePrefix("job")]
    public class JobDetailsController : Controller
    {    
        [HttpGet]
        [Route("details")]        
        public ActionResult Info()
        {
            JobInfo ji = new JobInfo {Description = "Hello"};
            return View(ji);
        }
        
        [HttpPost]
        [Route("details")]        
        public ActionResult Info(JobInfo info)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Confirm");
            }
            else
            {                
                return HttpNotFound();
            }
        }

        [Route("confirm")]
        public ActionResult Confirm()
        {
            return View();
        }
    }

  }