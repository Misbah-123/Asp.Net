using model_bussiness_layer_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace model_bussiness_layer_.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(int Id)
        {
            CompanyContext obj = new CompanyContext();
            Company st = obj.Comp.Single(x =>x.Id == Id);


            return View(st);
        }
    }
}