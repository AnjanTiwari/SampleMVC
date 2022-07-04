using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Login_form_with_remember_me_functionality.Models;

namespace Login_form_with_remember_me_functionality.Controllers
{
    public class LoginController : Controller
    {
        LoginDBEntities db = new LoginDBEntities();

        // GET: Login
        public ActionResult Index()
        {//// this will retrive data in text box after checking remeber me
         //// thats why we have added @@ Value  in view and requesting for cookie her in this method
            HttpCookie cuki = Request.Cookies["User"];
            if(cuki !=null)
            {
                ViewBag.usssername = cuki["Username"];
                ViewBag.Paaasword = cuki["Password"];

            }
            return View();
        }

        [HttpPost]
        public ActionResult Index(user u)
        {
            HttpCookie cookie = new HttpCookie("User");
            if(ModelState.IsValid==true)
            {
                if(u.RememberMe==true)
                {
                    //lets take two variables
                    cookie["Username"] = u.username;
                    cookie["Password"] = u.password;
                    cookie.Expires = DateTime.Now.AddDays(2);
                    HttpContext.Response.Cookies.Add(cookie);//this line will store the cookie in browsers memory

                }
                else
                {
                    cookie.Expires = DateTime.Now.AddDays(-1);
                    HttpContext.Response.Cookies.Add(cookie);//this line will store the cookie in browsers memory

                }
                //below is to show welcome page
                var row=db.users.Where(model=>model.username==u.username && model.password==u.password).FirstOrDefault();
                if(row!=null)
                {
                    Session["Username"] = u.username;
                    TempData["message"] = "<script>alert('login successfull!')</script>";
                    return RedirectToAction("Index", "Dashboard");

                }
                else
                {
                    TempData["message"] = "<script>alert('login failed')</script>"; 

                }
            }
            return View();
        }
    }
}