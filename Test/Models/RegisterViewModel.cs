using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Test.Models
{
    public class RegisterViewModel
    {
        public int UserID { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is Required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Username is Required")]
        [RegularExpression(@"^[a-zA-Z0-9]+$", ErrorMessage = "user name must be combination of letters and numbers only.")]
        [Remote("UsernameExists", "Account", HttpMethod = "POST", ErrorMessage = "User name already registered.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is Required")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Password is Required")]
        [System.Web.Mvc.Compare("Password", ErrorMessage = "Both Password fields must match.")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Email Address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [Remote("EmailExists", "Account", HttpMethod = "POST", ErrorMessage = "Email address already registered.")]
        public string Email { get; set; }
    }
}