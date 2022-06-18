using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Session.Controllers
{
    /*
    > Session is property of Controller class whose type is HttpSessionBase
    > it is also used to pass data within the MVC application.
    >it persists for expiration time ...default time is 20 minutes.
    >session is valid for all  requests not for single redirect.
    >it is also require typecasting  for getting data and check null value to avoid error
    >session has performance drawback because it slows down the applications

     */

    //in Web.config go here see bwlow tag
   //system.web>
   //sessionState timeout = "30" ></ sessionState >

    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.var1 = "this is result from viewbag";
            ViewData["var2"] = "this is result from viewdata";
            TempData["var3"] = "this is resultfrom tempdata";
            Session["var4"] = "this is result from Session";//default session time is 20 minutes

            string[] fruits = { "Apple", "banana", "grapes", "orange" };
            Session["abc"] = fruits;
            return RedirectToAction("About");
            //return View();
        }
        public ActionResult About()
        {
            if (Session["var4"] != null)
            {
                Session["var4"].ToString();
            }
            return View();
        }
        public ActionResult Contact()
        {
            if (Session["var4"] != null)
            {
                Session["var4"].ToString();
            }
            return View();
        }
    }
}