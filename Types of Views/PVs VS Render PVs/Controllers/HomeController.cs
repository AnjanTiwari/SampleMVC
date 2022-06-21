using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PVs_VS_Render_PVs.Controllers
{
    /*
     >Html.Partial :> Method returns MvcHtmlString (you can store it in some string variable)
                    > slow in access (beacuse it converts the result in to string then returns)
     Html.RenderPartial :> it doesnot return any value
                         >can't store in any variable
                         > fast in access
     
     
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