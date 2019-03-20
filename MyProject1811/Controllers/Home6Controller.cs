
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace MvcApplication1.Controllers
{
public class Home6Controller : Controller
{
public ActionResult Index6()
{
return View();
}
[HttpPost]
public ActionResult Index(string pname,int uprice, int qty)
{
int n = uprice * qty;
ViewData["ProductName"] = pname;
ViewBag.total = n;
return View();
}
}
}