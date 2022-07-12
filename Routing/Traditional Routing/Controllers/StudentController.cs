using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Traditional_Routing.Models;

namespace Traditional_Routing.Controllers
{
    /*
     https://www.youtube.com/watch?v=TtCkm7fOoKM&list=PLaFzfwmPR7_JuVN71I9pEpN8JadDTh0rg&index=20
     >Rounting is a pattern matching system for URL that maps incoming
    requst to controller action method
    >We set all routes in RouteConfig file in APP start.
    > We need to register all routes to make them operational
    >Route: is a pattern matching for particular URL.
    name:
    pattern:
    Default values:
    constraints if any:


    For attribute routing you just need to add this in route config file
    //route.MapMvcAttributeRoutes();
    that's it.









     */
    //[Route("Student")] when use on controller level then 
    //remove this part from other methods

    public class StudentController : Controller
    {
        //[Route("Student")]
        public ActionResult GetAllStudents()
        {
            var students = Students();
            return View(students);
        }
        //[Route("Student/{id}")]

        public ActionResult Student(int id)
        {
            var student = Students().Where(model => model.id == id).FirstOrDefault();
            return View(student);
        }
        //[Route("Student/{id}/Address")]

        public ActionResult GetStudentAddress(int id)
        {
            var studentAddress = Students().Where(model => model.id == id).Select(model => model.Address).FirstOrDefault();
            return View();
        }
        private List<Student> Students()
        {
            return new List<Student>()
            {
                new Student()
                {
                    id=111,
                    Name="Anjan",
                    Class="First",
                    Address= new Address()
                    {
                        HomeNumber=111,
                        Address1="badlapur",
                        City="Mumbai"
                    }
                },

                new Student()
                {
                    id=222,
                    Name="Aman",
                    Class="Second",
                    Address= new Address()
                    {
                        HomeNumber=200,
                        Address1="Kalyan",
                        City="Navi Mumbai"
                    }
                },

                new Student()
                {
                    id=333,
                    Name="Anjali",
                    Class="First",
                    Address= new Address()
                    {
                        HomeNumber=300,
                        Address1="Ghansoli",
                        City="Mumbai"
                    }
                }




            };
        } //for data purpose
    }
}