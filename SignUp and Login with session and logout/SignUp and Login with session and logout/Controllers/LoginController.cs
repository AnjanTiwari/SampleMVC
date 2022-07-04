using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SignUp_and_Login_with_session_and_logout.Models;

namespace SignUp_and_Login_with_session_and_logout.Controllers
{
    public class LoginController : Controller
    {
        SignupLoginEntities db = new SignupLoginEntities();

        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Signup(user u)
        {
            if (ModelState.IsValid == true)
            {
                db.users.Add(u);
                var a = db.SaveChanges();
                if (a > 0)
                {
                    ViewBag.insertmessage = "<script>alert('Registered successfully')</script>";
                    ModelState.Clear();
                }
                else
                {
                    ViewBag.insertmessage = "<script>alert('Registeration unsuccessfull')</script>";

                }
            }
            return View();
        }
        [HttpPost]
        public ActionResult Index(user u)
        {
            var user1 = db.users.Where(model => model.username == u.username && model.password == u.password).FirstOrDefault();
            if(user1!=null)
            {
                Session["userID"] = u.Id.ToString();
                Session["FirstName"] = u.username;
                TempData["LoginSuccessful"] = "<script>alert('login successfull')</script>";
                ModelState.Clear();
                return RedirectToAction("Index", "User");          
            }
            else
            {
                ViewBag.Errormessage  = "<script>alert('Username or Password incorrect!')</script>";
                
            }
            return View();
        }



    }
}