using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class UnitTestController : Controller
    {

        // GET: UnitTest
        public ActionResult Index()
        {
            ViewData["Hey"] = "Well Done";
            return View(ViewData["Hey"]);
        }
        public ActionResult Show(int id)
        {
            if (id%2==0)
            {
                ViewData["Number"] = "Evem Number";

                return View(ViewData["Number"]);
            }
            else
            {
                ViewData["Number"] = "Odd Number";

                return View(ViewData["Number"]);

            }
        }


    }
}