using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace authentication.Models
{
    public class Signup
    {

        [Key]
        [ScaffoldColumn(false)]
        public int Id
        {
            get; set;
        }
        [DataType(DataType.Text)]
        [Display(Name = "StudentName")]
        [Required(ErrorMessage = "Enter A Name ")]
        public string Name
        {
            get; set;
        }
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Please enter Email ID")]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Email is not valid.")]
        public string Email
        {
            get; set;
        }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Enter Password")]
        public string CurrentPassword
        {
            get; set;
        }

        [Required]
        [Display(Name = "Re-enter Password")]
        [Compare("CurrentPassword", ErrorMessage = "Please Re-enter Password Again")]
        public string ComparedPassword
        {
            get; set;
        }

    }
}