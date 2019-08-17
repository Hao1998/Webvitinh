using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace webvitinh.Models
{
    public class RegisterModel
    {
        [Key]
        public long Id { set; get; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "This field cannot be blank")]
        public string Username { set; get; }


        [Display(Name = "Password")]
        [Required(ErrorMessage = "This field cannot be blank")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "It's to short")]
        public string Password { set; get; }


        [Display(Name = "Confirm Your Password")]
        [Compare("Password", ErrorMessage = "Your password confirm is not correct !")]
        public string ConfirmPassword { set; get; }


        [Display(Name = "Your Fullname")]
        [Required(ErrorMessage = "This field cannot be blank")]
        public string Name { set; get; }


        [Display(Name = "Your Email")]
        [Required(ErrorMessage = "This field cannot be blank")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { set; get; }


        //[Display(Name = "Your Address")]
        //[Required(ErrorMessage = "This field cannot be blank")]
        //public string Address { set; get; }


        [Display(Name = "Your Phone Number")]
        [Required(ErrorMessage = "This field cannot be blank")]
        public string Phone { set; get; }

        [Display(Name = "Province")]
        public int ProvinceID { set; get; }


        [Display(Name = "District")]
        public int DistrictID { set; get; }
    }
}