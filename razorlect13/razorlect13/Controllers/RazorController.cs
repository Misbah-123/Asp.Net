using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace razorlect13.Controllers
{
    public class RazorController : Controller
    {
        // GET: Razor
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Add()
        {
            @Razor.inlinehelper(new string[] { "Irha", "Umaima", "Aaira" });
            return View();
        }
    }
}