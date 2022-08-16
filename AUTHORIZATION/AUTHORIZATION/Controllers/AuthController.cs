using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AUTHORIZATION.Controllers
{
    public class AuthController : Controller
    {
        // GET: Auth
        [AuthorizeAttribute]
        public ActionResult Index()
        {
            return View();
        }

        [Authorize(Users = "irha@gmail.com")]
        public ActionResult About()
        {
            return View();
        }


    }
}