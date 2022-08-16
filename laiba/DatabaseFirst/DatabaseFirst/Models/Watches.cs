using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DatabaseFirst.Models
{
    [Table("info")]
    public class Watches
    {
        public int id { get; set; }
        public string name { get; set; }
        public int price { get; set; }
    }
}