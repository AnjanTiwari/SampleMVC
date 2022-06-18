
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using View_Data.Models;

namespace View_Data.Controllers
{
    /*
     you can use the following object to pass data between controller and view
    1. ViewData
    2. ViewBag
    3. TempData
    4. Session

    >it passes data from controller to view
    >it is dictionary of objects from ViewDataDictionary class.
    >if you want to sent data from one view to other view it can't be possible
    because it exist only during current request.
    >Viewdata requires typecasting when dealing with complex data types to avoid error
    > Syntax ViewData["Key"] = <Value>

    >View data does not provide compiletime errors so don't do spelling mistakkes.
    it well lead to nullreference exception.
    */
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewData["Message"] = "Message from view Data";
            ViewData["Current Time"] = DateTime.Now.ToLongTimeString();

            ///lets take an array and pass it
            string[] fruits = { "Apple", "banana", "grapes", "orange" };
            ViewData["Fruits Array"] = fruits;

            //lets take a list and pass it
            ViewData["Sports list"] = new List<string>()
            { "Cricket",
                "football",
                "swimming",
                "javeline"
            };

            //similary we can pas objects also for that herewe have made a class in Model
            Employee emp = new Employee();
            emp.Id = 111;
            emp.Name = "Anjan";
            emp.Designation = "Manager";

            ViewData["EmployeeInfo"] = emp;



            return View();
        }
    }
}