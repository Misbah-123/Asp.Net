using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC_entity_.Models
{
    public class shoescontext:DbContext
    {
        public DbSet<Shoes> tae
        {
            get;
            set;
        }

    }
}