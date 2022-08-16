using Cvuploading.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;


namespace Cvuploading.Controllers
{
    public class UploadingController : Controller
    {
        // GET: Uploading
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(upload mi, HttpPostedFileBase File)
        {
            if (File == null)
            {
                ModelState.AddModelError("customererror", "Select file");
                return View();

            }
            if (!(File.ContentType == "application/msword" || File.ContentType == "application/pdf"))
            {

                ModelState.AddModelError("customerror", "please select doc / pdf file only ");
                return View();
            }


            if (ModelState.IsValid == true)
            {


                try
                {
                    string filename = Guid.NewGuid() + Path.GetExtension(File.FileName);
                    File.SaveAs(Path.Combine(Server.MapPath("~/Cv_uploading"), filename));

                    using (fileuploadingEntities db = new fileuploadingEntities())
                    {
                        mi.CV = filename;
                        db.uploads.Add(mi);
                        db.SaveChanges();


                        ModelState.Clear();
                        mi = null;
                        ViewBag.Message = "Submited";

                    }

                }
                catch (Exception ex)
                {
                    ViewBag.Message = "Not Submited";
                    return View();
                }
                
            }
            return View();
        }
    }
}
