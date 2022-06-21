using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Strongly_typed_views.Models;
namespace Strongly_typed_views.Controllers
{
    public class HomeController : Controller
    {
        /*
         >strongly typed view or strongly type object is used to pass data from
        controller to view
        >the view which is bind with models are callled strongly typed views
        >you can bind any class as model to view
        >you can access model properties to that view
        >you can use data associated with model to render controls
        > In strongly typed views it is bind with corresponding model class object orlist of objects
        >it provides compile time error checking and intellicense

         
         
         */
        // GET: Home
        public ActionResult Index()
        {
            /* 1)
            //Employee emp1 = new Employee();
            //emp1.ID = 11;
            //emp1.Name = "Anjan";
            //emp1.age = 25;
            //return View(emp1); */

            Employee emp2 = new Employee();
            emp2.ID = 22;
            emp2.Name = "Ankush";
            emp2.age = 15;

            Employee emp3 = new Employee();
            emp3.ID = 12;
            emp3.Name = "Akash";
            emp3.age = 15;
            List<Employee> emp = new List<Employee>();
            
            emp.Add(emp2);
            emp.Add(emp3);
            return View(emp);
        }
    }
}