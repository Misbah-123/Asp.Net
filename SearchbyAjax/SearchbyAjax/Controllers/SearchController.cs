using SearchbyAjax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SearchbyAjax.Controllers
{
    public class SearchController : Controller
    {
        SearchEntities obj = new SearchEntities(); 
        // GET: Search
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult Searchpeople(string keyword)
        {
            var data = obj.infoes.Where(mi => mi.Name.StartsWith(keyword)).ToList();

            return PartialView(data);
        }

    }
}