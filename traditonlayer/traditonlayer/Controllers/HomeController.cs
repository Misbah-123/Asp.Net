using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using traditonlayer.Models;

namespace traditonlayer.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Traditionlayer obj = new Traditionlayer();
            List<Teachers> list = obj.Teachers.ToList();

            return View(list);
        }
    }
}