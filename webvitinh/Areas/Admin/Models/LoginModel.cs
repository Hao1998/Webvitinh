using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace webvitinh.Areas.Admin.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Please type in your Username")]
        public string Username { set; get; }

        [Required(ErrorMessage = "Please type in your Password")]
        public string Password { set; get; }


        public bool Remember { set; get; }
    }
}