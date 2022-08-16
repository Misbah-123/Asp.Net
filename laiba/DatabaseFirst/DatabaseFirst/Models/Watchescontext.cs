using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DatabaseFirst.Models
{
    public class Watchescontext:DbContext
    {
       public DbSet<Watches> Retail { get; set; }

    }
}