﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Difference_betwwen_cookies_and_session.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        public ActionResult Index()
        {
            HttpCookie cookie = Request.Cookies["Username"];
            if(cookie!=null)
            {
                ViewBag.mesage = Request.Cookies["Username"].Value.ToString();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}