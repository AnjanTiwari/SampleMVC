using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Authorize_Filter.Controllers
{
    /*
     Authorization
    Authorization is the  process of verifying whether an authenticated
    user  has the privilage to access a requested resource.

    Authentication :
    Authentication is process of validating the identity of user before
    granting access to a restricted resource in an application.

    >Authorization filter executes before action method invoked to make
    security decisions on whetere allow the execution of action method or not

    >AuthorizeAttribute class System.web.Mvc namespace is an example of 
    authorization filters.

    >this class implements IAuthorizationFilter Interface.

    >You can use web.config file to specify the page to be displayed
    for user authentication.

    > the <forms> element specifies the login url for the application
    > whenever user tries to use restricted resource it redirected to login
    form

    >the timeout attribute in the <forms> specifies time in minutes
    after which authentication cookie expires . default time is 30 minutes.

     
     
     
     
     
     */






    // [Authorize] //if we keep it here it will directly get you to the 
    //login form
    [Authorize]
    public class HomeController : Controller
    {
        // GET: Home

        //suppose authorize is given on controller level but still you
        //want to show home page at least i.e the index method view
        //then use this [AllowAnnonymous]
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
        //[Authorize] 
        public ActionResult Contact()
        {
            return View();
        }
    }
}