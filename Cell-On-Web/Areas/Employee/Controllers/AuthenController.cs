using Cell_On_Web.Areas.Employee.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cell_On_Web.Areas.Employee.Common;

namespace Cell_On_Web.Areas.Employee.Controllers
{
    public class AuthenController : Controller
    {
        // GET: Employee/Authen
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Login(int Id) {
            CheckLogin.SetEmployeeLogin(new EmployeeLogined() { 
                Address = "1",
                DepartmentId = 1,
                Email = "1",
                Id =1,
                Name = "1",
                Pass = "1",
                Phone = "1",
                UserName = "1"
            });
            return Json(Id,JsonRequestBehavior.AllowGet);
        }

        public ActionResult Logout()
        {
            CheckLogin.SetEmployeeLogin(null);
            return RedirectToAction("Index");
        }
    }
}