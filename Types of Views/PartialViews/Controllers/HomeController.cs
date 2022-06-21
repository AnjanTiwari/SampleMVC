using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartialViews.Controllers
{
    /*
     >Partial views are subview of a main view
     >partial views allows you to rescue common markups across  the different
    views of application.
    >we can't use partial views separately ...it dependent on some View
    >extension is same as normal views .cshtml
    >when we have to use some html markup on some pages not all pages then we can use partial views
    >there are two types of PVs static and dynamic
    >for PVs we use two html helper methods 
    Html.partial() and Html.RenderPartial()

     
     
     
     
     */
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Contact()
        {

            return View();

        }
    }
}