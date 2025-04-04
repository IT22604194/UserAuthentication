﻿
using System.ComponentModel.DataAnnotations;

namespace UserAuthentication.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage ="Name is required.")]
        public String Name { get; set; }

        [Required(ErrorMessage ="Email is required.")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Password is required.")]
        [StringLength(40, MinimumLength =8, ErrorMessage ="The {0} must be at {2} and at max {1} charactors long.")]
        [DataType(DataType.Password)]
        [Compare("ConfirmPassword", ErrorMessage = "Password does not match.")]
        public string Password { get; set; }
        [Required(ErrorMessage ="Confirm Password is required.")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        public String ConfirmPassword { get; set; }
    }
}
