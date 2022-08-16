using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace model_bussiness_layer_.Models
{
     [Table("info")]

    public class Company
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string des { get; set; }
        public int salary { get; set; }
    }
}