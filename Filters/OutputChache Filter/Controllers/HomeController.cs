using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OutputChache_Filter.Models;

namespace OutputChache_Filter.Controllers
{
    /*
    > A result filter operates on the result that an action method returns.
    > The OutputChacheAtrribute class is one example of a result filter
    which is  used to mark an action method whose output will be cached.
    > the content can be reused to service subsequent requests for the same URL
    >Chaching action output increases performance because of resusability

    >it has properties like duration,location
    >location specifies where the put can be chached it takes enum values
    and can be stored at 

    >Any(by default>
    >Client
    >Downstream(proxy)
    >None(no chaching)
    >Server
    >Server And Client
     
     
     
     */


    public class HomeController : Controller
    {
        PersonDBmdfEntities db = new PersonDBmdfEntities();
        // GET: Home
        [OutputCache(Duration = 10, Location = System.Web.UI.OutputCacheLocation.Server)] //duratoin is in seconds

        public ActionResult Index()
        {
            ViewBag.Time = DateTime.Now.ToLongTimeString();

            return View();
        }

        [OutputCache(Duration = 40)] //duratoin is in seconds

        public ActionResult GetData()
        {
            var data = db.people.ToList();
            return View(data);  
        }
    }
}