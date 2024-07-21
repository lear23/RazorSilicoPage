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
                return Page();
            }
            return RedirectToPage("/index");

        }
    }
}
