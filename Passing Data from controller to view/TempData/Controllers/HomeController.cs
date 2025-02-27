﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TempData.Controllers
{
    /*
    > TempData is a Dictionary object derived  from the TestDataDictionary class
    >Syntax :
    TempData[<key>]=<value>;
    >TempData value must be  type cast before use.
    >TempData allows passing data from the current request to  the subsequent request
    during request redirection.
    >TempData in mvc can be used to store temporary data  which can be used in subsequent(very next)
    request
    >Call TempData.Keep() to keep all the values    of tempdata in third request .
     
     */
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.var1 = "this is result from viewbag";
            ViewData["var2"] = "this is result from viewdata";
            TempData["var3"] = "this is resultfrom tempdata";


            string[] fruits = { "Apple", "banana", "grapes", "orange" };

            TempData["tempDataArray"] = fruits;
            return RedirectToAction("About"); // this will escape Index and execute About.
           // return View();
        }
        public ActionResult About()
        {
            if(TempData["var3"] != null)
            {
                TempData["var3"].ToString();
            }
            TempData.Keep(); //we use it to go with data to some other(next) request or view ....better use sessions than this function 
            return View();
        }
        public ActionResult Contact()
        {

            return View();
        }
    }
}