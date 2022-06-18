using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActionLink_method.Controllers
{
    /*
     Html helper methods used to render html content in a view
    >these are methods to Html Helper Class, can be called only from views.
    >it simplifies the process of creating view.
    >allows generating HTML markup that you can reuse accross  the Webapp.

    Eg.
    HTML.ActionLink
    HTML.BeginForm() and HTML.EndForm()
    HTML.Label()
    HTML.TextBox()
    HTML.TextArea()
    HTML.Paassword()
    HTML.CheckBox()
    HTML.RedioButton()
    HTML.hidden()
    HTML.DropDownList()

    Html.ActionLink() allows to generate hyperlink that points to an action method
    of a controller class
    Syntax : Html.ActionLink(link text,action method name,Controller name)
     
     
     
     */
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AboutUs()
        {
            return View();
        }
        public ActionResult ContactUS()
        {
            return View();
        }
    }
}