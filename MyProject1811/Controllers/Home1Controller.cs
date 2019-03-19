using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyProject1811.Controllers
{
    public class Home1Controller : Controller
    {
        public ActionResult Index1()
        {
            return View();
        }

        public ActionResult Details1()
        {
            string sname = "Scott";
            int m1 = 85, m2 = 96, m3 = 75;
            int total = GetTotal(m1, m2, m3);
            Response.Write("Student Name: " + sname);
            Response.Write("<br>");
            Response.Write("Total Marks: " + total);
            return View();
        }
        [NonAction]
        public int GetTotal(int m1, int m2, int m3)
        {
            int n = m1 + m2 + m3;
            return n;
        }
        public ActionResult GetServerTime()
        {
            string str = DateTime.Now.ToString();
            return Content(str);
        }
    }
}