using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Login_form_with_remember_me_functionality.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        public ActionResult Index()
        {
            if(Session["Username"]==null)
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                return View();

            }
        }
        public ActionResult LogOut()
        {
            if(Session["Username"] != null)
            {
                Session.Abandon();
                return RedirectToAction("Index", "Login");


            }
            return View();
        }
    }
}