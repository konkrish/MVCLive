using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCLive.Controllers
{
    public class ActionsController : Controller
    {
        // GET: Actions
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ViewBag1()
        {
            ViewBag.Message = "This is from controller";
            List<string> Student = new List<string>();
            Student.Add("Jignesh");
            Student.Add("Tejas");
            Student.Add("Rakesh");

            ViewBag.Student = Student;
            return View();
        }

        public ActionResult ViewData1()
        {
            List<string> Student = new List<string>();
            Student.Add("Jignesh");
            Student.Add("Tejas");
            Student.Add("Rakesh");

            ViewData["Student"] = Student;
            return View();
        }

        public ActionResult TempData1()
        {
            List<string> Student = new List<string>();
            Student.Add("Jignesh");
            Student.Add("Tejas");
            Student.Add("Rakesh");

            TempData["Student"] = Student;
            return View();
        }
    }
}