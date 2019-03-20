using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyProject1811.Controllers
{
    public class Home2Controller : Controller
    {
        //
        // GET: /Home2/

        public ActionResult Index2()
        {
            return View();
        }
        public ActionResult StudInfo()
        {
            return View();
        }
        public ActionResult CourseName()
        {
            return View();
        }
        public ActionResult CourseNameArray()
        {
            return View();
        }
        public ActionResult DataEntryForm()
        {
            return View();
        }
        public ActionResult ProductDetails()
        {
            return View();
        }
        public ActionResult AdditionOperation()
        {
            var s = Request["t1"];
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
    }
}
