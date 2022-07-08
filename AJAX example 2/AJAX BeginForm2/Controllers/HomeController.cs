using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AJAX_BeginForm2.Models;

namespace AJAX_BeginForm2.Controllers
{
    public class HomeController : Controller
    {
        EmployeeDBEntities db = new EmployeeDBEntities();
        // GET: Home
        public ActionResult Index()
        {

            return View(db.employees.ToList());
        }

        [HttpPost]
        public ActionResult Index(string e)
        {
            if(string.IsNullOrEmpty(e)==false)
            {
                List<employee> emp = db.employees.Where(model => model.name.StartsWith(e)).ToList();
                return PartialView("_searchData", emp);
            }
            else
            {
                List<employee> emp = db.employees.ToList();
                return PartialView("_searchData", emp);
            }
        }
    }
}