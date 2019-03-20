using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication2.Models;
namespace MvcApplication2.Controllers
{
    public class Home4Controller : Controller
    {
        public ActionResult Index4()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index4(Dept obj)
        {
            Response.Write("DeptNo:" + obj.Deptno);
            Response.Write("<br/> DeptName: " + obj.Dname);
            Response.Write("<br/> Location: " + obj.Location);
            return View();
        }
    }
}