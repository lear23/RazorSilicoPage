using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorSilicoPage.Models;
using System.ComponentModel.DataAnnotations;

namespace RazorSilicoPage.Pages
{
    public class SignInModel : PageModel
    {
        [BindProperty]
        public SignInViewModel Form { get; set; } = new SignInViewModel();

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
    }

}
