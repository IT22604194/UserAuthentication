using System.ComponentModel.DataAnnotations;

namespace UserAuthentication.ViewModels
{
    public class LoginViewModel
    {


        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress]
        public String Email { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name ="Remeber me?")]
        public bool RememberMe { get; set; }
    }
}
