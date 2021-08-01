using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCLive.Controllers
{
    [MyLogActionFilter]
    public class FiltersController : Controller
    {
        // GET: Filters
        public ActionResult Index()
        {
            return View();
        }

        [OutputCache(Duration = 20)] // Seconds
        public string GetCurrentTime()
        {
            return DateTime.Now.ToString("T");
        }

        [HandleError(ExceptionType = typeof(DivideByZeroException), View = "Error")]
        public int GetHandleExceptionFilter()
        {
            int i = 1;
            //int u = Convert.ToInt32("");
            return i / 0;
        }
    }
}