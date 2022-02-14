using MVCApplication_ErrorHandling.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApplication_ErrorHandling.Controllers
{
    public class HomeController : Controller
    {
        private ILog _ILog;

        public HomeController()
        {
            _ILog = Log.GetInstance;
        }

        // We override OnException method to handle all error that we have get from our controller.
        // After we override it, we do not need try catch block any more 
        // If we have any exception in our code, this method will be executed
        protected override void OnException(ExceptionContext filterContext)
        {
            _ILog.LogException(filterContext.Exception.ToString());
            filterContext.ExceptionHandled = true;
            this.View("Error").ExecuteResult(this.ControllerContext);
        }
        public ActionResult Index()
        {
            // We use it to throw in exception and execute OnException method
            int number = 10;
            var error=number / 0;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}