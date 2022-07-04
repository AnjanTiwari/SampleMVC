using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web; ///this is for handling image posted 
using System.Web.Mvc;
using Uploading_and_retriving_Images.Models;

namespace Uploading_and_retriving_Images.Controllers
{
    public class HomeController : Controller
    {
        UploadRetriveImagesEntities db = new UploadRetriveImagesEntities();
        // GET: Home
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Product p)
        {
            string fileName = Path.GetFileNameWithoutExtension(p.ImageFile.FileName);//we aregetting file nameof image
            string extension = Path.GetExtension(p.ImageFile.FileName);//getting extension ofimage in another variable
            fileName = fileName + extension;//this will be stored in Image folder
            p.Image_path = "~/Images/" + fileName;
            fileName = Path.Combine(Server.MapPath("~/Images/"), fileName);//this image path will store on server we are telling to server that there is folder called images add this file there
            p.ImageFile.SaveAs(fileName);
            db.Products.Add(p);
            var a = db.SaveChanges();
            if(a>0)
            {
                ViewBag.message = "Record inserted !!";
                ModelState.Clear();
            }
            else
            {
                ViewBag.message = "Record not inserted";
            }
            

            return View(a);
        }
    }
}