using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Binding_DropdownList_with_Database.Models;

namespace Binding_DropdownList_with_Database.Controllers
{
    public class HomeController : Controller
    {
        SearchFunctionalityEntities db = new SearchFunctionalityEntities();
        // GET: Home
        public ActionResult Index()
        {
            List<Emp> Emplist = db.Emps.ToList();
            ViewBag.List1 = new SelectList(Emplist,"id", "Name");//here id is value for associated name you can check this in source code. you can put 'name' also 
            return View();
        }
    }
}