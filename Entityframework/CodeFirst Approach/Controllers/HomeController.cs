using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CodeFirst_Approach.Models;
using System.Data.Entity;

namespace CodeFirst_Approach.Controllers
{
    /*
     Code First Approach :

    >it is mostcommon approach iplemented in MVC framework.
    >Devlop your own application by coding model classes and properties and delegate
    the process of creating the database objects to the EntityFramework
    >this aproach allows to define your own model by creating custom clases
    >later you can create database models

    The DBContext class : 

    > it is present in Sytem.Data.Entity namespace in EF.
    >can be defined  the database context class after creating model class.
    >it coordinates with EF na dallows you to query and save the Database.
    >Uses the DbSet<T>  type to define one or more properties where T represents
    the type of an object that needs to be  stored in Database
     
     
     
     
     */
    public class HomeController : Controller
    {
        StudentContext db = new StudentContext();

        // GET: Home

        //Read
        public ActionResult Index()
        {
            var data = db.Students.ToList();

            return View(data);
        }

        ///Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student s)
        {
            if(ModelState.IsValid==true)
            {
                db.Students.Add(s);
               var a= db.SaveChanges(); //this method return an iteger 1 or 0 ..1 if successfully inserted
                if(a>0)
                {
                    ///ViewBag.Inserted = "<script>alert('Data inserted !!')</script>";
                    ///ModelState.Clear();
                    //Now sppose if you want to get redirected to you list page  after creating 
                    //a record then we should use tempdata and RedirectAction()
                    ///TempData["Success"] = "<script>alert('Data inserted !!')</script>";
                    //if you want the success mesage inside the index page itself instead of alert then
                    TempData["Success"] = "Data inserted !!";
                    return RedirectToAction("Index");

                }
                else
                {
                    ViewBag.Inserted = "<script>alert('Data not inserted !!')</script>";

                }

            }
            return View();

        }


        //Update
        public ActionResult Edit(int id)
        {
            //if ID is present in db then return whole row
           var row = db.Students.Where(modell => modell.Id == id).FirstOrDefault();

            return View(row);
        }

        [HttpPost]
        public ActionResult Edit(Student s)
        {
            if(ModelState.IsValid==true)
            { 
            db.Entry(s).State = EntityState.Modified;
            var a=db.SaveChanges();
            if(a>0)
            {
               // ViewBag.Edited = "<script>alert('Data Updated !!')</script>";
               // ModelState.Clear();
                TempData["Edited"] = "Data Updated !!";
                return RedirectToAction("Index");

            }
            else
                {
                TempData["Edited"] = "Data is not Updated !!";
                }
            }
            return View();
        }

        ///Delete
        ///
        ///If you want confirmation the create delete view and apply logic 
        ///but if you don't want confirmation the apply below way
        ///
        public ActionResult Delete(int id)
        {
            if(id>0)
            {
                var studentidrow = db.Students.Where(model => model.Id == id).FirstOrDefault();
                if(studentidrow != null)
                {
                    db.Entry(studentidrow).State = EntityState.Deleted;//this present in System.data.entity
                    int a = db.SaveChanges();
                    if(a>0)
                    {
                       // TempData["DeletemMessage"] = "<script>alert('Data deleted !!')</script>";
                        TempData["DeletemMessage"] = "Data deleted !!";

                    }
                    else
                    {
                        TempData["DeletemMessage"] = "<script>alert('Data not deleted !!')</script>";

                    }
                }
            }
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            var DetailsbyID = db.Students.Where(model => model.Id == id).FirstOrDefault();
            return View(DetailsbyID);
        }
    }
}