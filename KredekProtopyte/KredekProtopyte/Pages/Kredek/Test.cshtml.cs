using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace KredekProtopyte.Pages.Kredek
{
    public class TestModel : PageModel
    {
        public TestModel()
        {
            TestContent = new List<string>() {
                "@await Html.PartialAsync(\"TemplatesPartials/_BannerTextAndLinksPartial\")",
                "<h2> TEST H2 </h2>"
            };
        }

        public List<string> TestContent { get; set; }

        public void OnGet()
        {
        }
    }
}