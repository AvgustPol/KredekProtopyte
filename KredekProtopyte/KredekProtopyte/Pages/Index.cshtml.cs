using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KredekProtopyte.Pages
{
    public class IndexModel : PageModel
    {
        public IActionResult OnGetAsync()
        {
            return RedirectToPage("/Kredek/Index");
        }
    }
}