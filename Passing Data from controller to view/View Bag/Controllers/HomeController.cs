using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using View_Bag.Models;

namespace View_Bag.Controllers
{
    /*
     > ViewBag is also Datadictionary object.
     > it is also passes data from controller to view
     >if you want to sent data from one view to other view it can't be possible
    because it exist only during current request.
    >Viewdata does not requires typecasting when dealing with complex data types
    >ViewBag is dynamic property based on the dynamic features.
    >Syntax :
    ViewBag.<Property Name> = <value>;

    >View data does not provide compiletime errors so don't do spelling mistakkes.
    it well lead to nullreference exception.

    >ViewData and ViewBag can access each others data interchangeably..

    >while using ViewBAG AND ViewData if you want to use data of another view in some 
    other view it won't work.

     
     */
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Message = "Message from Viewbag !!!";// Message custom dynamic property
            ViewBag.CurrentDate = DateTime.Now.ToLongDateString();
            string[] fruits = { "Apple", "banana", "grapes", "orange" };
            ViewBag.Fruitarray = fruits;

            ViewBag.sports = new List<string>()
            {
                "Cricket",
                "football",
                "swimming",
                "javeline"
            };

            Employee emp = new Employee();
            emp.Id = 222;
            emp.Name = "anjan";
            emp.Designation = "Manager";
            ViewBag.Employeee = emp;


            return View();
        }
    }
}