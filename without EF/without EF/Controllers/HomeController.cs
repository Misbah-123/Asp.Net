using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using without_EF.Models;

namespace without_EF.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            Traditionlayer obj = new Traditionlayer();
            List<Teachers> list = obj.teachers.ToList();

            return View(list);
        }
    }
}