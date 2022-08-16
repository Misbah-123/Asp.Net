using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_entity_.Models
{
    public class shoesLayer
    {
        public List<Shoes> getallrecords()
        {

            shoescontext obj = new shoescontext();
            List<Shoes> items = obj.tae.ToList();
            return items; 
        }
    }
}