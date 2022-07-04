using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Exception_Filters
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            //to use global filter 
            GlobalFilters.Filters.Add(new HandleErrorAttribute());
            /*
               5. IF you want to call your own specific view while handling error 
            instead of Error.cshtml then you have to ddefine it separately in 
                Global.asax.cs like this

            GlobalFilters.Filters.Add(new HandleErrorAttribute() { View="Error2"});
             */
        }
    }
}
