using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace dataauthentication.Models
{
    public class Signupcontext : DbContext
    {
        public DbSet<Signup> Signups { get; set; }
    }
}