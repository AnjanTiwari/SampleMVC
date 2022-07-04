using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Difference_betwwen_cookies_and_session.Models;

namespace Difference_betwwen_cookies_and_session.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(User u)
        {
            if(ModelState.IsValid==true)
            {
                HttpCookie cookie = new HttpCookie("Username");
                cookie.Value = u.Username;

                HttpContext.Request.Cookies.Add(cookie); //this line will add our coookie data in browsers memory
                cookie.Expires = DateTime.Now.AddDays(2);//just by adding this line it will become persistant cookie for 2 days.
                return RedirectToAction("Index", "Dashboard");
            }
            return View();
        }
    }
}