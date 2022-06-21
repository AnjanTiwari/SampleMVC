using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Strongly_typed_Helper_Methods.Controllers
{
    /*
     Following table lists the helper methods that we can use onlyin strongly type views
    >Html.LabelFor()
    >Html.displayNameFor()
    >Html.displayFor()
    >Html.TextBoxFor()
    >Html.TextBoxAreaFor()
    >Html.EditorFor()
    >Html.PasswordFor()
    >Html.DropDownList()
     
     
     
     
     */
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}