using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Annotation.Models
{
    public class studContext:DbContext
    {
        public DbSet<stud> student
        {
            get;
            set;
        }
    }
}