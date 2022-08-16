using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace code_first_approach.Models
{
    public class MakeuoContext : DbContext
    {
        public DbSet<Makeup> Make { get; set; }
    }

   
}