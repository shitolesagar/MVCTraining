using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace MvcApplication1.Controllers
{
public class Home7Controller : Controller
{
    public ActionResult Index7()
    {
        return View();
    }
public ActionResult Login7()
{
return View();
}
[HttpPost]
public ActionResult Login7(string uid, string pwd)
    {
if (uid == "admin" && pwd == "admin123")
{
TempData["UserName"] = uid;
return RedirectToAction("Index");
}
else
{
    ViewBag.ErrorMessage = "Invilid username or password";
    return View();
}
    }
}
}
