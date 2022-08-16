using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace model_bussiness_layer_.Models
{
    public class CompanyContext : DbContext
    {
        public DbSet<Company> Comp { get; set; }
    }
}