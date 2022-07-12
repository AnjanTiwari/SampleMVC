using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Business_Library;

namespace Dependency_Injection.Controllers
{
    /* Problems if we don't use DI
     1)Tight coupling
    2)Controllers knows where the code is written they can access
    all methods of business layer and have to change according to them
    and their implmentation eg. database type changes
    3) Not easy to write unit tests

    Implementation: 
    we wll use Interfaces which will have contract for business layer 
    classes
    so we will make a pipeline in a config(Unity library or Simple injecter) file where we will declare 
    that which Business LAYER class implements which interface 

    so that home controller won't be able to knnow about classes of business
    layer and their details 

    this config files will resolve the dependency.

    three ways to resolve DI
    contrustor,method,and property 
    we have used here construtor

    once you install unity.mvc5 there will be class created in app start 
    unity.config.cs
    you have to add there the Interfaces and BL classes
    also add the unity.register component to GLobal.asax



              
              */

    public class HomeController : Controller
    {
        //private Employee _employee = null;
        //instead of above we will use below way for DI
        private IEmployee _employee = null;
        //Similary one more example
        private IStudent _studennt = null;
        public HomeController(IEmployee employee,IStudent student)
        {
            _employee = employee;
            _studennt = student;
        }
        public ActionResult Index()
        {
            int count = _employee.getStudents();
            bool mystudent = _studennt.IsStudent();

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}