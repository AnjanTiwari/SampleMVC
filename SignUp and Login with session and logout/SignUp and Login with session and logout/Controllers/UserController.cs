using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SignUp_and_Login_with_session_and_logout.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            if(Session["userID"]==null)
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
            Session.Abandon();

            return RedirectToAction("Index", "Login");

        }
    }
}