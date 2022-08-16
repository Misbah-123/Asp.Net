using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using with_model.Models;

namespace with_model.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
                
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
            return View();
        }
    }
}