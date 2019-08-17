using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace webvitinh.Models
{
    public class LoginModel
    {
        [Key]
        [Display(Name = "Username")]
        [Required(ErrorMessage = "This field is required to login !")]
        public string Username { set; get; }

        [Required(ErrorMessage = "This field is required to login !")]
        [Display(Name = "Password")]
        public string Password { set; get; }
    }
}