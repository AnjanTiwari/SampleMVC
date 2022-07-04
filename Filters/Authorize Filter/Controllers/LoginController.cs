
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security; //to use class FormsAuthentication
using Authorize_Filter.Models;

namespace Authorize_Filter.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        LoginDBEntities db = new LoginDBEntities();

        //[AllowAnonymous]//if you are using global authorization
        //otherwise even login form won't show in output.
        public ActionResult Index()
        {
            return View();
        }

        //below method to check credentials are rightor not         
        public bool IsVaalid(user u)
        {

            var credentials = db.users.Where(model => model.username == u.username && model.password == u.password).FirstOrDefault();
            //if we don't keep below return in if else block then it will throw null reference eception
            if (credentials != null)
            {
                return (credentials.username == u.username && credentials.password == u.password);
                //above line will return true if such row exist in db or credential isahving any single value else it wll return false

            }
            else
            {
                return false;
            }
        }



        //now here we are coming with true or false value of credentials so no need to worry about authentication in below method
       // [AllowAnonymous] //if you are using global authorization

        [HttpPost]
        public ActionResult Index(user u, string ReturnUrl)
        {
            //that ReturnUrl is containing the Contact page  which will not be 
            //accessible without logging in. matlb uske upper authorize filter laga hua hai
            if(IsVaalid(u)==true)//i.e user is genuine
            {
                FormsAuthentication.SetAuthCookie(u.username, false);///as we are creating temporary cookie so keeping it false otherwise we would have set as true for parmanent one
                Session["username"] = u.username.ToString();
                if(ReturnUrl !=null)
                {
                    return Redirect(ReturnUrl);
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            else
            {
                return View();

            }

        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();//that cookie created ealier will be dstroyed
            Session["username"] = null;
            return RedirectToAction("Index", "Home");
        }



    }
}