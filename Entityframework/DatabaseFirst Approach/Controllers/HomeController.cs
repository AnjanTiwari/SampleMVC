using DatabaseFirst_Approach.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace DatabaseFirst_Approach.Controllers
{
    /*
     Database first appraoch : 
    steps : create project > install EF > Add new Item for model > select in Data field
    >ADO.NET entity data model class> add the connnections > test connection with server>
    >make controller > data model class will have extention of .edmx > make object of 
    data context class in home controller> have a index method >add db.savechanges()
    > add view ....
     
    >>    [ScaffoldColumn(false)] :
    this one we have not implemented in this project so youcan create all
    columns after going on create new but...if you want to hide or don't want to
    add certain columns while create new then just put this annotation before the 
    property in model class then create template view ...and you won't see those columns

    
     
     
     */
    public class HomeController : Controller
    {
        DatabaseFirstEFEntities db = new DatabaseFirstEFEntities();
        // GET: Home
        public ActionResult Index()
        {
            var data = db.Students.ToList();
            
            return View(data);
        }

        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Create(Student s)
        {
            if (ModelState.IsValid == true)
            {
                db.Students.Add(s);
                var a = db.SaveChanges();
                if (a > 0)
                {
                    TempData["created"] = "Data inserted!! ";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["created"] = "Data failed to insert!! ";

                }
            }

            return View();
        }

        public ActionResult Edit(int id)
        {
            var row=db.Students.Where(model => model.Id == id).FirstOrDefault();
            
            return View(row);
        }

        [HttpPost]
        public ActionResult Edit(Student s)
        {
            db.Entry(s).State = EntityState.Modified;
            int a = db.SaveChanges();
            if (a > 0)
            {
                TempData["updated"] = "Data updated!! ";
                return RedirectToAction("Index");
            }
            else
            {
                TempData["updated"] = "Data failed to update!! ";

            }
            return View();
        }

        //public ActionResult Delete(int id)
        //{
        //    var Deletedrow = db.Students.Where(model => model.Id == id).FirstOrDefault();

        //    return View(Deletedrow);
        //}

        //[httpPost]
        //public ActionResult Delete(Student s)
        //{
        //    db.Entry(s).State = EntityState.Deleted;
        //    var a = db.SaveChanges();
        //    if (a > 0)
        //    {
        //        TempData["Deleted"] = "Data deleted !! ";
        //        return RedirectToAction("Index");
        //    }
        //    else
        //    {
        //        TempData["Deleted"] = "Data failed to update!! ";

        //    }
        //    return View();
        //}

        //if you don't want confirmation page of delete then delete the delete view
        //and follow below way.

        public ActionResult Delete(int id)
        {
            if (id > 0)
            {
                var Deletedrow = db.Students.Where(model => model.Id == id).FirstOrDefault();
                if (Deletedrow != null)
                {

                    db.Entry(Deletedrow).State = EntityState.Deleted;
                    var a = db.SaveChanges();
                    if (a > 0)
                    {
                        TempData["Deleted"] = "Data deleted !! ";
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        TempData["Deleted"] = "Data failed to update!! ";
                    }
                }
            }
            return View();
        }
        public ActionResult Details(int id)
        {
            var row = db.Students.Where(model => model.Id == id).FirstOrDefault();

            return View(row);
        }


    }
}