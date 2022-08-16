using createbyajax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace createbyajax.Controllers
{
    public class CreateController : Controller
    {
        SearchEntities db = new SearchEntities();
        // GET: Create
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {

            return View();

        }
        [HttpPost]
        public ActionResult Create(info emp)
        {
          if(ModelState.IsValid == true)
            {
                db.infoes.Add(emp);
                int a = db.SaveChanges();//
                if (a > 0)
                {
                    return Json("Data Inserted ");
                }
                else
                {

                    return Json("Please Insert Data");
                }

            }
        
            return View();

        }
    }
}