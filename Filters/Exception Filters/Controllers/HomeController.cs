using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exception_Filters.Controllers
{
    /*
     * Exception is abnormal condition which stops execution when occcur
     Exception is an event that disrupts the normal flow by throwing an 
    object in runtime.

    ->Excetion filters are additional exception handling components in MVC
    framework which comprises try-catch block within
    
    ->MVC provides built in exeption filter through the HandleError filter
    that the HandleErrorAttributees class implements.

    -> to use HandleError Filter in MVC application  you have to do 3 steps
    1.It returns a view named Error.cshtml which by default in shared folder
    thats why we have to create Error.cshtml view inn shared folder.

    2.To use  the handle Error you need to confugure the web.config file
    by adding customErrors attribute inside <System.web> element
    like this <customErrors mode="On" />

    3.use [HandleError] attribute before action method,controller or Global.

    4.I f you want  to use the filter for whole application put 
    it in Global.asax global.asaz.cs file

    5. IF you want to call your own specific view while handling error 
    instead of Error.cshtml then you have to ddefine it separately in 
    Global.asax.cs like this 

    6.If you are using MVC template insted of Empty then this HandleError is already 
    present in project
        So error.cshtml file in Shared folder and FilterConfig.cs in Appstart folder 
        is present you just need to add that customErrros in Web.config

    7.Limitations  of Handle Error
     a.It does not handles 404,401 error i.e if you mistake in url speling 
    it doesn't works for that
      
    b. For this purpose you need to create custom filters
         
     
     */
    // [HandleError] //at controller level

    public class HomeController : Controller
    {
        // GET: Home
       // [HandleError]
        //[HandleError]
        public ActionResult Index()
        {
            throw new Exception();
            return View();
        }

        /*
         IF you want to call your own specific view while handling error 
        instead of Error.cshtml then you have to ddefine it separately 
         like this 
        [HandleError(View="Error2")]

         */
        public ActionResult About()
        {
            throw new Exception();
            return View();
        }
    }
}