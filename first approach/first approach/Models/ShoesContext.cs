using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace first_approach.Models
{
    public class ShoesContext : DbContext
    {
        public DbSet<Shoes> Shoes { get; set; }
    }
}