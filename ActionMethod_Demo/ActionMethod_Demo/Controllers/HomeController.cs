using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActionMethod_Demo.Controllers
{
    /*Action methods are public methods it returns acationresult objects that 
     encapsulates the result of executing methods
    It can't be private,protected and static.
    they cant be overloaded versions based on parameters
    We can create multiple action methods in a controller
     */
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public string Show()
        {
            return " Hello Anjan Tiwari";
        }
        public ActionResult AboutUs()
        {
            return View();
        }
        public int StudentID(int id)
        {
            return id;
        }
    }
}