using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dataauthentication.Controllers
{
    public class UserController : Controller
    {
        Signuo= obj = new Db();
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Signup()
        {
            return View();
        }



        [HttpPost]
        public ActionResult Signup(Signup model)
        {

            Signup s = new Signup();
            s.Name = model.Name;
            s.Email = model.Email;
            s.CurrentPassword = model.CurrentPassword;
            s.ComparedPassword = model.ComparedPassword;
            obj.signups.Add(s);
            obj.SaveChanges();
            return RedirectToAction("Login");
        }


        public ActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Login(Signup model)
        {
            Signup s = obj.signups.Where(a => a.Email.Equals(model.Email)
               && a.CurrentPassword.Equals(model.CurrentPassword)).SingleOrDefault();
            if (s != null)
            {
                return RedirectToAction("userDashboard");
            }





            return View();





        }





        public ActionResult userDashboard()
        {
            return View();
        }
    }