using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorSilicoPage.Pages.Partials.HomePartial
{
    public class _FeaturesModel : PageModel
    {
        public List<FeatureBoxViewModel> Features { get; set; } =
            [
               new FeatureBoxViewModel { Icon="images/icon.svg", Description="Id mollis consectetur congue egestas egestas suspendisse blandit justo.", Title="Coments on Tasks" },
               new FeatureBoxViewModel { Icon="images/icon2.svg", Description="Non imperdiet facilisis nulla tellus Morbi scelerisque eget adipiscing vulputate.", Title="Tasks Analytics" },
               new FeatureBoxViewModel { Icon="images/icon3.svg", Description="A elementum, imperdiet enim, pretium etiam facilisi in aenean quam mauris.", Title="Multiple Assignees" },
               new FeatureBoxViewModel { Icon="images/icon4.svg", Description="Diam, suspendisse velit cras ac. Lobortis diam volutpat, eget pellentesque viverra.", Title="Notifications" },
               new FeatureBoxViewModel { Icon="images/icon5.svg", Description="Id mollis consectetur congue egestas egestas suspendisse blandit justo.", Title="Sections & Subtasks" },
               new FeatureBoxViewModel { Icon="images/icon6.svg", Description="Aliquam malesuada neque eget elit nulla vestibulum nunc cras.", Title="Data Security" },
            ];
        
        public void OnGet()
        {
        }
    }

    public class FeatureBoxViewModel
    {

        public string Icon { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
    }
}
