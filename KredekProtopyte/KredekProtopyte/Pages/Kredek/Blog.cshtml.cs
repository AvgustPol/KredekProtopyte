using FacebookPageGetter.Models.FeedPostDto;
using FacebookPageGetter.Services.FacebookService;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;
using System.Threading.Tasks;

namespace KredekProtopyte.Pages.Kredek
{
    public class BlogModel : PageModel
    {
        private IFacebookService _facebookService;

        public BlogModel(IFacebookService facebookService)
        {
            _facebookService = facebookService;
        }

        public FeedPostsDto FeedPostsDto { get; set; }

        public async Task OnGetAsync()
        {
            FeedPostsDto = await _facebookService.GetPostsAsync(5);

            Debug.Write("test");
        }
    }
}