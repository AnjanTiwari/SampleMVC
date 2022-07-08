using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using By_using_Partial_Views.Models;

namespace By_using_Partial_Views.Controllers
{
    public class HomeController : Controller
    {
        MultipleModelDataInSingleViewEntities db = new MultipleModelDataInSingleViewEntities();

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult Student()
        {
            var std = getStudents();
            return PartialView("_students", std);
        }

        public PartialViewResult Teacher()
        {
            var tchr = getTeachers();
            return PartialView("_teachers", tchr);
        }
        public List<student> getStudents()
        {
            return db.students.ToList();
        }
        public List<teacher> getTeachers()
        {
            return db.teachers.ToList();
        }
    }
}