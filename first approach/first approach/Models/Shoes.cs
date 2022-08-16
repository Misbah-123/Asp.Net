using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace first_approach.Models
{
    [Table("info")]
    public class Shoes
    {
        public int Id { get; set; }
        public string brand { get; set; }
        public int price { get; set; }
    }
}