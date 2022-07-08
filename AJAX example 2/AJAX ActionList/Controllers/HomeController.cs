using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AJAX_ActionList.Models;

namespace AJAX_ActionList.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        EmployeeDBEntities db = new EmployeeDBEntities();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AllEmployees()
        {
            var data = db.employees.ToList();
            return PartialView("_Employees", data);
        }

        public ActionResult Top3()
        {
            var data = db.employees.OrderByDescending(model=>model.salary).Take(3).ToList();
            return PartialView("_Employees", data);
        }

        public ActionResult Bottom3()
        {
            var data = db.employees.OrderBy(model=>model.salary).Take(3).ToList();
            return PartialView("_Employees", data);
        }
    }
}