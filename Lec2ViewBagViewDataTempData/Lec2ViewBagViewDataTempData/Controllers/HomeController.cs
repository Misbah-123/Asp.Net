using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lec2ViewBagViewDataTempData.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {


            ViewBag.Name = "Umaima";
            ViewBag.Class = "3th";
            ViewBag.Age = "5";

            ViewBag.obj = new List<string>()
            {
                "laiba",
                "Irha",
                "Ayesha",
                 "Romana"



            };
            return View();
        }

        public ActionResult ViewDataIndex()
        {


            ViewData["Name"] = "Saad";
            ViewData["Class"] = "4th";
            ViewData["Age"] = "8";

            ViewData["obj"]= new List<string>()
            {
                "laiba",
                "Irha",
                "Fatima",
                 "Mariam"



            };
            return View();
        }

        public ActionResult TempDataIndex()
        {


            TempData["Name"] = "Fawaad";
            TempData["Class"] = "5th";
            TempData["Age"] = "8";

            TempData["obj"] = new List<string>()
            {
                "Sobia",
                "Zimal",
                "Fatima",
                 "Mariam"



            };
            return RedirectToAction("About");
        }
        
        public ActionResult About()
        {
            TempData["Name"] = "Umaima";

            return View();

        }

    }
}