using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace data_annotation.Models
{
    public class Makeupcontext : DbContext
    {
        public DbSet<Makeup> Make { get; set; }
    }
}