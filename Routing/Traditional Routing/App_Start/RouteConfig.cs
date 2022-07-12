using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Traditional_Routing
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapMvcAttributeRoutes(); for attribute routing

            routes.MapRoute(
                name: "ALLStudents",
                url: "Students",
                defaults: new { controller = "Student", action = "GetAllStudents" }
                );

            routes.MapRoute(
                name: "ALLStudents1", //this name should be different
                url: "Students/{id}", //whatever user pasess at runtime that we write in {}
                defaults: new { controller = "Student", action = "Student" },
                //but there might be situation where user might enter abc instead of integer id 
                //so to avoid that error we use constraints

                constraints= new {@"\d+"} //this regular exoression you can pss
                );


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
