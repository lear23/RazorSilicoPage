using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;

namespace RazorSilicoPage.Pages.Partials.HomePartial
{
    public class _ShowCaseModel : PageModel
    {
        public List<string> Brands { get; set; } =
        [
              " images/brandipsum1.svg",
              " images/brandipsum2.svg",
              " images/brandipsum3.svg",
              " images/brandipsum4.svg"
         ];

        public void OnGet()
        {
           
        }
    }
}
