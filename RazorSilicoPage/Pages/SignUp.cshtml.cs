using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorSilicoPage.Models;

namespace RazorSilicoPage.Pages
{
   

    public class SignUpModel : PageModel
    {
        public string PageTitle { get; set; } = "Sign Up";

        [BindProperty]
        public SignUpViewModel Form { get; set; } = new SignUpViewModel();

     
        public void OnGet()
        {

            

        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                // Debugging: Logga valideringsfel
                foreach (var state in ModelState)
                {
                    foreach (var error in state.Value.Errors)
                    {
                        Console.WriteLine($"Error in {state.Key}: {error.ErrorMessage}");
                    }
                }

                return Page();
            }
            return RedirectToPage("/index");
        }

    }
}
