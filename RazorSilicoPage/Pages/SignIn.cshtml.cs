using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace RazorSilicoPage.Pages
{
    public class SignInModel : PageModel
    {
        [BindProperty]
        public SignInForm? Form { get; set; }

        public string PageTitle { get; set; } = "Sign In";

        public void OnGet()
        {
            // Inicialización o lógica adicional si es necesario.
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            return RedirectToPage("/index");

        }

        public class SignInForm
        {
            [Required]
            [EmailAddress]
            public string? Email { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string? Password { get; set; }

            [Required]
            public bool Terms { get; set; }
        }
    }

}
