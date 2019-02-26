using KredekProtopyte.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KredekProtopyte.Pages.Kredek
{
    public class IndexModel : PageModel
    {
        public BannerTemplate BannerTemplate { get; set; }

        public void OnGet()
        {
            BannerTemplate = new BannerTemplate()
            {
                ImageUrl = "https://images.wallpaperscraft.com/image/desert_sand_sky_136050_1920x1080.jpg",
                SubTitle = "Creation and Development Group",
                Title = "Kredek"
            };
        }
    }
}