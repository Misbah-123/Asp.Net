using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace with_model.Models
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Student obj = new Student()
            {
                id = 1,
                name = "Umaima",
                age = "3",
                contact = "0303"
            };
            return View(obj);
        }

        public ActionResult Index1()
        {
            Student obj1 = new Student()
            {
                id = 101,
                name = "Aptech Center",
                contact = "0313"
            };
            return View(obj1);
        }
    }

    }