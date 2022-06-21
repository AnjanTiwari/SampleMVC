using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text.RegularExpressions;

namespace Validation_message_and_Validation_summary.Controllers
{
    /*
     Validation message : It is an extension method that is a loosely typed method.
    It displays a validation message if an error exists in specific field in the (through)
    ModelStateDictionary object.

    Validation Summary : this helper method generates an unordred list of validation message
    that are in ModelStateDictionary object.
    It can be used to display all error messages for al fields.
    It can also be used to display custom error messages like we did it here.
     
     
     
     */
    public class HomeController : Controller
    {
        string EmailPatern = "A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)Z";
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string fullname, string Age, string Email)
        {

            if(fullname.Equals("")==true)
            {
                ModelState.AddModelError("fullname", "Full name is required !");
                ViewData["Fullname Error"] = "*";
            }
            if (Age.Equals("") == true)
            {
                ModelState.AddModelError("Age", "Age is required !");
                ViewData["Age Error"] = "*";

            }
            if (Email.Equals("") == true)
            {
                ModelState.AddModelError("Email", "Email is required !");
                ViewData["Email Error"] = "*";

            }
           
            if (Regex.IsMatch(Email, EmailPatern) == false)
            {
                ModelState.AddModelError("Email", "Email is Invalid!");
                ViewData["Email Error"] = "*";

            }

            return View();
        }
    }
}