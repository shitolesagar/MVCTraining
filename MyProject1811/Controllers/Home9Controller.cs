using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _5AdoDotNet.Models;
namespace _5AdoDotNet.Controllers
{
public class Home9Controller : Controller
{
DataContext db = new DataContext();
public ActionResult Index9()
{
List<Dept> deptList = db.GetDepts();
return View(deptList);
}
public ActionResult Create9()
{
return View();
}
[HttpPost]
public ActionResult Create9(Dept obj)
{
db.AddDept(obj);
return RedirectToAction("Index");
}
    public ActionResult Details9(int id)
{
Dept Obj = db.GetDept(id);
return View(Obj);
}
public ActionResult Edit9(int id)
{
Dept obj = db.GetDept(id);
return View(obj);
}
[HttpPost]
public ActionResult Edit9(Dept obj)
{
db.EditDept(obj);
return RedirectToAction("Index");
}
public ActionResult Delete9(int id)
{
Dept obj = db.GetDept(id);
return View(obj);
}
[HttpPost]
public ActionResult Delete9(String id)
{
    int n = int.Parse(id);
    db.DeleteDept(n);
    return RedirectToAction("Index");
}
}
}
