using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AjaxBeginFormMVC.Models;

namespace AjaxBeginFormMVC.Controllers
{
    /*
     
     AJAX :

    >AJAX stands for Asynchronus Jaavascript and XML
    >It is web development technique which allows you to make request
    to the server in the background using client-side code
    >enables you to update the view without reloading the the page
    >It enables partial page updates i.e only related section of page 
    updates without reloading entire page.
    >AJAX comprises of : HTML,CSS,Javascript,XML,Json,PHP
    >Asynchronus communication : it is ability of web application to send
    multiple requests from the server
    >AC enables you to work on application without getting affected from 
    response recived by server
    >AJAX are non-blocking.
    >MVC also uses set og AJAX helpers they enables to create forms links
    that point to controller actions.
    >the only difference is it is asynchronus
    >While using AJAX helpers you not need to use javascript explicitly
    to make it asynchronus
    >make sure you should have jquery.unobstrusive-ajax script file is present in
    present in script folder
    >MVC framework provides builtin support for unobstrusive AJAX
    >you need to configure web.config file.
    >you need to set UnbstrusiveJavaScriptEnabledProperty to true under
    <appSettings> element of web.config

     */

    public class HomeController : Controller
    {
        EmployeeDBEntities db = new EmployeeDBEntities();

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        //Actionrsult can handle anything Json,javascript,partial views etc.
        public ActionResult Create(Table t) //code snippet mvcpost+tab
        {
            if(ModelState.IsValid==true)
            {

            db.Tables.Add(t);
            var a = db.SaveChanges();
                if(a>0)
                {
                    //thid json will display in that div DivUpdate
                    return Json("data inserted !!");//Javascript object notation 
                    /*
                     
                     lets return javascript so that we can get pop up after insertion
                    
                     this will be catched by that empty div 
                    
                    return JavaScript("alert('Data inserted !!')");//Javascript object notation 
                     
                     
                     */

                }
                else
                {
                    return Json("data not inserted inserted !!");
                }
            }


            return View();
        }

        
    }
}