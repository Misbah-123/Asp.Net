using roles_in_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace roles_in_MVC.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Signup()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Signup(usert model)
        {
            using (var context = new rolesEntities())
            {
                context.userts.Add(model);


            }

            return RedirectToAction("Login");
        }

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Members mem)

        {
            using (var context = new rolesEntities())
            {
                bool isvalid = context.userts.Any(x => x.Name == mem.Name && x.Pass == mem.Pass);

                if (isvalid)
                {
                    FormsAuthentication.SetAuthCookie(mem.Name, false);

                    return RedirectToAction("Dashboard");
                }
            }
            ModelState.AddModelError("", "Invalid user name or password");
            return View();


        }

        public ActionResult Dashboard()
        { 
            return View();
            
            }

    }
}