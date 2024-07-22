using System.ComponentModel.DataAnnotations;

namespace RazorSilicoPage.Models
{
    public class SignUpViewModel
    {
        [DataType(DataType.Text)]
        [Display(Name = "First name", Prompt = "Enter your first name")]
        [Required(ErrorMessage = "First name is required.")]
        public string FirstName { get; set; } = null!;

        [Display(Name = "Last name", Prompt ="Enter your last name")]
        [Required(ErrorMessage = "Last name is required.")]
        public string LastName { get; set; } = null!;


        [DataType(DataType.Text)]
        [Display(Name = "Email address", Prompt = "Enter your email address")]
        [Required(ErrorMessage = "Email address is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address format.")]
        public string Email { get; set; } = null!;

    
        [Display(Name = "Password", Prompt = "********")]
        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)] 
        public string Password { get; set; } = null!;

        [Display(Name = "Confirm Password", Prompt = "********")]
        [Required(ErrorMessage = "Please confirm your password.")]
        [DataType(DataType.Password)] 
        [Compare(nameof(Password), ErrorMessage = "Passwords do not match.")]
        public string ConfirmPassword { get; set; } = null!;

        [Display(Name = "Terms & Conditions")]
        [Required(ErrorMessage = "You must agree to the terms and conditions.")]
        [CheckBoxRequired(ErrorMessage = "You have to accept the Terms & Conditions to proceed,")]
        public bool Terms { get; set; }
    }

    public class CheckBoxRequired : ValidationAttribute
    {
        public override bool IsValid(object? value) => value is bool b && b;
    }
}
