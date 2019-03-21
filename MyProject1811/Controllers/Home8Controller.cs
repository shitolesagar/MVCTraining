using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.Models;
namespace MvcApplication1.Controllers
{
public class Home8Controller : Controller
{
public ActionResult Index8()
{
//Step 1 prepare data to send view
Dept obj = new Dept();
obj.DeptNo = 10;
obj.DName = "Accounts";
obj.Loc = "Pune";
//step 2 send data using view method
return View(obj);
}
public ActionResult Index82()
{
    //Step 1 prepare data to send view
    List<Dept> deptlist = new List<Dept>();
    Dept d1 = new Dept() { DeptNo = 10, DName = "Account", Loc = "Hyd" };
    Dept d2 = new Dept() { DeptNo = 20, DName = "sales", Loc = "Pune" };
    Dept d3 = new Dept()
    {
        DeptNo = 30,
        DName = "Marketing",
        Loc = "Mumbai"
    };
    deptlist.Add(d1);
    deptlist.Add(d2);
    deptlist.Add(d3);
    //step 2 send data using view method
    return View(deptlist);
}
}
}