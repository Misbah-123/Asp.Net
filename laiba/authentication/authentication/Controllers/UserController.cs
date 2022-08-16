using authentication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace authentication.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        Db obj = new Db();
        
      

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
                //object type
                //HttpCookie hc1 = new HttpCookie("userid", s.Id.ToString());
                //Response.Cookies.Add(hc1);

                //HttpCookie hc2 = new HttpCookie("email", s.Email.ToString());
                //Response.Cookies.Add(hc2);


                //keyvalue
                //Response.Cookies["email"].Value = s.Email.ToString();
                //Response.Cookies["userid"].Value = s.Id.ToString();


                //step #1
                //HttpCookie hc1 = new HttpCookie("userid", s.Id.ToString());
                //hc1.Expires = DateTime.Now.AddSeconds(10);
                //Response.Cookies.Add(hc1);
                //HttpCookie hc2 = new HttpCookie("email", s.Email.ToString());
                //hc2.Expires = DateTime.Now.AddSeconds(10);
                //Response.Cookies.Add(hc2);

                Session["UserID"] = s.Id.ToString();
                Session["UserEmail"] = s.Email.ToString();
                return RedirectToAction("userDashboard");
            }





            return View();





        }





        public ActionResult userDashboard()
        {
            return View();
        }
        public ActionResult Logout()
        {
            //step#2
            Session.Abandon();
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }









    }
}