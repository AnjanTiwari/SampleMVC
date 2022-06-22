using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Required.Models;

namespace Required.Controllers
{
    public class HomeController : Controller
    {
        /*
         * Data Annotations OR Model based Validation
         >MVC framework provides several data annotations that you can  apply as attributes
        to a model.
        > these DAs implement tasks that are commonly required accross applications
        >Some of the imp  annotations that you can  use in models of ASP.NET MVC applications
        1.Required
        2.StringLength
        3.RegularExpression
        4.Range
        5.Compare
        6.Readonly
        7.Datatype
        8.ScaffoldColumn



         
         
         
         */
        // GET: Home
        public ActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Index(Employee emp)
        {
            if(ModelState.IsValid==true)
            {
                ViewData["SuccesMessage"] = "<script>alert('Data is been sucessfully submitted')</script>";
                ModelState.Clear();
            }
            return View();
        }
    }
}