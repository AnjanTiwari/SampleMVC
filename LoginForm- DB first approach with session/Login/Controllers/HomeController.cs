using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Login.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            if(Session["logged"]==null) //here we ensuring that user must be logged in before coming to this page
            {
                return RedirectToAction("Index", "Login");
            }
            return View();
        }
    }
}