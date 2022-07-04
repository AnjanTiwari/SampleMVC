using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exception_Filters.Controllers
{
    public class UseController : Controller
    {
        // GET: Use
        public ActionResult Index()
        {
            throw new Exception();
            return View();
        }
    }
}