using System.Web;
using System.Web.Mvc;
using MVC_Razor.Models;

namespace MVC_Razor.Controllers
{
    [RoutePrefix("job")]
    public class JobDetailsController : BaseController
    {
        [HttpGet]
        [Route("details")]
        public ActionResult Info()
        {
            JobInfo ji = new JobInfo();
            //ji.Description = "col";
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
                return View(info);
            }
        }

        [Route("confirm")]
        public ActionResult Confirm()
        {
            return View();
        }

        [Route("test")]
        public ActionResult Test(int first, int second)
        {
            return View();
        }

        
    }

    public class BaseController : Controller
    {
        protected override void OnException(ExceptionContext filterContext)
        {
            var exception = filterContext.Exception;

            base.OnException(filterContext);
        }
    }
}