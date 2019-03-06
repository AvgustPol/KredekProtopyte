using KredekProtopyte.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KredekProtopyte.Pages.Template
{
    public class BaseModel : PageModel
    {
        public PageContent PageContent { get; set; }

        public void OnGet()
        {
        }
    }
}