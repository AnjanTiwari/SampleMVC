using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Strongly_typed_Helper_Methods.Models;

namespace Strongly_typed_Helper_Methods.Controllers
{
    public class Home1Controller : Controller
    {
        // GET: Home1
        public ActionResult Index()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult Index(Calculator cal)
        {
            var a = cal.num1;
            var b = cal.num2;
            var result = a + b;
            ViewBag.result = result;


            return View();
        }
    }
}