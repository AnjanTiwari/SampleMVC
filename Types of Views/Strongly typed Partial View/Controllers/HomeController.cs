using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Strongly_typed_Partial_View.Models;

namespace Strongly_typed_Partial_View.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<Product> productlist = new List<Product>()
            {
                new Product{ id=111,name="Rolex Watch",price=10000,picture="~/Images/watch.jpg"},
                new Product{ id=222,name="Pen",price=1000,picture="~/Images/Pen.png"},
                new Product{ id=111,name="Phone",price=15999,picture="~/Images/Phone.jpg"}

            };

            return View(productlist);
        }
    }
}