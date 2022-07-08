using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using By_Creating_extra_class_in_models_folder.Models;

namespace By_Creating_extra_class_in_models_folder.Controllers
{
    public class HomeController : Controller
    {
        MultipleModelDataInSingleViewEntities db = new MultipleModelDataInSingleViewEntities();
        // GET: Home
        public ActionResult Index()
        {
            var std = getStudents();
            var tchr = getTeachers();

            /* comment below 3 lines of object creation and storage to implement Viebag */
            /* ViewBag.student = std;
             ViewBag.teacher -= tchr;*/

            /*to implment it through viewdata 
            ViewData["student"]=std;
            ViewData["teacher]=tchr;
            
            */
            MultiModelData data = new MultiModelData();
            data.my_students = std;
            data.my_teachers = tchr;

            return View(data);
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