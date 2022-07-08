using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AJAX_Load_more_funnctionality.Models;


namespace AJAX_Load_more_funnctionality.Controllers
{
    public class HomeController : Controller
    {
        EmployeeDBEntities db = new EmployeeDBEntities();

        // GET: Homr
        public ActionResult Index()
        {
            int num = 5;
            Session["data"] = num;
            var data = db.employees.Take(5).ToList();
            return View(data);
        }

        [HttpPost]
        public ActionResult Index(employee e)
        {
            var rows = Convert.ToInt32(Session["data"]) + 3;
            var data = db.employees.ToList().Take(rows);
            Session["data"] = rows;

            return View("_employeedetails",data);
        }
    }
}