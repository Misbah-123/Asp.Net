using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace data_annotation.Models
{
    [Table("make")]
    public class Makeup
    {
        [Key]
        [ScaffoldColumn(false)]
        public int ID { get; set; }
        
        [DataType(DataType.Text)]

        [Required(ErrorMessage = "Please enter name"), MaxLength(30)]
        [Display(Name = "Brand Name")]
        public string Name { get; set; }
        

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Please enter Email ID")]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Email is not valid.")]

        public string Email
        {
            get; set;
        }
        

        [Required(ErrorMessage = "Please enter price")]

        public int price
        {
            get; set;
        }
        

    }
}