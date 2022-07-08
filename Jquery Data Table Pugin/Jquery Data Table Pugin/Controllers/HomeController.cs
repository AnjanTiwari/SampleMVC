using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Jquery_Data_Table_Pugin.Models;

namespace Jquery_Data_Table_Pugin.Controllers
{
    public class HomeController : Controller
    {
        EmployeeDBEntities db = new EmployeeDBEntities();
        // GET: Home
        public ActionResult Index()
        {
            var data = db.employees.ToList();
            return View(data);
        }
    }
}