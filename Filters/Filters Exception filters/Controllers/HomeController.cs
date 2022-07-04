using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filters_Exception_filters.Controllers
{
    /*
     MVC Application workflow :
    Client->Route/routing->controller->ActionMethod->View
    In MVC application there might be a situation where you neet to 
    implement some functionality before or after the execution of an
    action method here you need filters.
    =>Five types of filters in MVC5
    1. Authentication filters
    2. Authorization filters
    3. Action filters
    4. Result Filters
    5. Exception Filters
    Note : all filters will aply as per sequence of declaration in code
    We can have built in and custom filters.
    You can use filters at following levels:
    1. Action Method Level
    2. Controller Level
    3. Application Level

     
     
     */
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //DevidebyZero exception
            //int a = 10;
            //int b = 0;
            //int c = a / b;

            //IndexOutofRange exception
            //int[] a = new int[3];
            //a[0] = 14;
            //a[1] = 15;
            //a[2] = 15;
            //a[3] = 5;

            //NullReference Exception
            //string a = null;
            //int b = a.Length;

            // throw new Exception(); //this class is parent of all exception classes in c#

            //lets see how we handle it 
            try
            {
                throw new Exception();
            }
            catch (Exception ex)
            {
                return RedirectToAction("Errorpage", "Home");
                //and here on error page we would have shown the exception message 
                //but we can avoid all this just by using Exception filters
                //for that checkout another project 
            }

            return View();
        }
    }
}