using fileuploading.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace fileuploading.Controllers
{
    public class FileController : Controller
    {
        // GET: File
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(info mi, HttpPostedFileBase File)
        { 
            if(File == null)
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
                    File.SaveAs(Path.Combine(Server.MapPath("~/cv_uploading"), filename));

                    using (SearchEntities db = new SearchEntities())
                    {
                        mi.CV = filename;
                        db.infoes.Add(mi);
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