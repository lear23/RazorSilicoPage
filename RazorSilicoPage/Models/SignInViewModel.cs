using Razorlibrary.Helpers;
using System.ComponentModel.DataAnnotations;

namespace RazorSilicoPage.Models
{
    public class SignInViewModel
    {
        [DataType(DataType.Text)]
        [Display(Name = "Email address", Prompt = "Enter your email address")]
        [Required(ErrorMessage = "Email address is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address format.")]
        public string Email { get; set; } = null!;


        [Display(Name = "Password", Prompt = "********")]
        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;

        [Display(Name = "Terms & Conditions")]
        [Checkboxrequired(ErrorMessage = "You have to accept the Terms & Conditions to proceed.")]
        public bool Terms { get; set; }


    }
}
