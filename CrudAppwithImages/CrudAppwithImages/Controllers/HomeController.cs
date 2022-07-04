using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CrudAppwithImages.Models;
using System.IO;
using System.Data.Entity;


namespace CrudAppwithImages.Controllers
{
    public class HomeController : Controller
    {
        CrudAppWithImagesEntities db = new CrudAppWithImagesEntities();

        // GET: Home
        public ActionResult Index()
        {
            var data = db.employees.ToList();
            return View(data);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(employee e)
        {
            if (ModelState.IsValid == true)
            {
                string fileName = Path.GetFileNameWithoutExtension(e.ImageFile.FileName);
                string extension = Path.GetExtension(e.ImageFile.FileName);
                HttpPostedFileBase postedfile = e.ImageFile;
                int length = postedfile.ContentLength;//Calculating sizze of image
                if (extension == ".jpg" || extension == ".jpeg" || extension==".png")
                {
                    if(length<10000000)
                    {
                        fileName = fileName + extension;
                        e.image_path = "~/Images/" + fileName;
                        fileName = Path.Combine(Server.MapPath("~/Images/"), fileName);
                        e.ImageFile.SaveAs(fileName);
                        db.employees.Add(e);
                        var a = db.SaveChanges();
                        if(a>0)
                        {
                            TempData["CreateMessage"] = "<script>alert('Image inserted!!')</script>";
                            ModelState.Clear();
                            return RedirectToAction("Index", "Home");
                        }
                        else
                        {
                            TempData["CreateMessage"] = "<script>alert('Image is not inserted!!')</script>";

                        }
                    }
                    else
                    {
                        TempData["ImagesizeMessage"] = "<script>alert('File size should be less than 1MB')</script>";

                    }
                }
                else
                {
                    TempData["ExtensionMessage"] = "<script>alert('File format not support !')</script>";
                }
            }
                return View();
        }
        public ActionResult Edit(int id)
        {
            var Employeerow = db.employees.Where(model => model.id == id).FirstOrDefault();
            Session["image1"] = Employeerow.image_path;
            return View(Employeerow);
        }

        [HttpPost]
        public ActionResult Edit(employee e)
        {
            if(ModelState.IsValid==true)
            {
                if(e.ImageFile!=null)
                {

                    string fileName = Path.GetFileNameWithoutExtension(e.ImageFile.FileName);
                    string extension = Path.GetExtension(e.ImageFile.FileName);
                    HttpPostedFileBase postedfile = e.ImageFile;
                    int length = postedfile.ContentLength;
                    if (extension == ".jpg" || extension == ".jpeg" || extension == ".png")
                    {
                        if (length < 10000000)//number is in bytes
                        {
                            fileName = fileName + extension;
                            e.image_path = "~/Images/" + fileName;
                            fileName = Path.Combine(Server.MapPath("~/Images/"), fileName);
                            e.ImageFile.SaveAs(fileName);
                            db.Entry(e).State = EntityState.Modified;
                            var a = db.SaveChanges();
                            if (a > 0)
                            {
                                /*bellow if block is for deleting image from image folder beacuse it gets deleted from UI but not from folder 
                                 and if do'not deleted it from folder application becomes havieour*/
                                string ImagePath = Request.MapPath(Session["Image1"].ToString());
                                if (System.IO.File.Exists(ImagePath))//if image path exists in Images folder as we had given directory of imges folder in MapPath() which we had store on server
                                {
                                    System.IO.File.Delete(ImagePath);
                                }
                                TempData["UpdatedMessage"] = "<script>alert('Image updated!!')</script>";
                                ModelState.Clear();
                                return RedirectToAction("Index", "Home");
                            }
                            else
                            {
                                TempData["UpdatedMessage"] = "<script>alert('Image is not updated!!')</script>";

                            }
                        }
                        else
                        {
                            TempData["ImagesizeMessage"] = "<script>alert('File size should be less than 1MB')</script>";

                        }
                    }
                    else
                    {
                        TempData["ExtensionMessage"] = "<script>alert('File format not support !')</script>";
                    }
                }

                else//if you want to change something other than image copy some code from above & edit 2 lines
                {
                    e.image_path = Session["Image1"].ToString();//here we are keeping the same image 
                    db.Entry(e).State = EntityState.Modified;//here we are modifying everything other than image
                    var a = db.SaveChanges();
                    if (a > 0)
                    {
                        TempData["UpdatedMessage"] = "<script>alert('Data updated!!')</script>";
                        ModelState.Clear();
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        TempData["UpdatedMessage"] = "<script>alert('Data is not updated!!')</script>";
                    }
                }
            }
            return View();
        }

        public ActionResult Delete(int id)
        {
            var employeerow = db.employees.Where(model => model.id == id).FirstOrDefault();
            if(employeerow!=null)
            {
                db.Entry(employeerow).State = EntityState.Deleted;
                var a = db.SaveChanges();
                if(a>0)
                {
                    TempData["DeleteMessage"] = "<script>alert('Data is Deleted!!')</script>";
                    /*bellow if block is for deleting image from image folder beacuse it gets deleted from UI but not from folder 
                    and if do'not deleted it from folder application becomes havieour*/
                    string ImagePath = Request.MapPath(employeerow.image_path.ToString());
                    if (System.IO.File.Exists(ImagePath))//if image path exists in Images folder as we had given directory of imges folder in MapPath() which we had store on server
                    {
                        System.IO.File.Delete(ImagePath);
                    }
                }
                else
                {
                    TempData["DeleteMessage"] = "<script>alert('Data is not Deleted!!')</script>";

                }
            }
            return RedirectToAction("Index","Home");


        }

        public ActionResult Details(int id)
        {
            var Employeerow = db.employees.Where(model => model.id == id).FirstOrDefault();
            Session["Image2"] = Employeerow.image_path.ToString();

            return View(Employeerow);
        }

    }
}