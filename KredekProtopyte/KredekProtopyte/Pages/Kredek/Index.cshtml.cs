using KredekProtopyte.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KredekProtopyte.Pages.Kredek
{
    public class IndexModel : PageModel
    {
        public BannerTemplate BannerTemplate { get; set; }
        public ImageAndTextTemplate ImageAndTextTemplateLeft { get; set; }
        public ImageAndTextTemplate ImageAndTextTemplateRight { get; set; }

        public void OnGet()
        {
            BannerTemplate = new BannerTemplate()
            {
                ImageUrl = "https://images.wallpaperscraft.com/image/desert_sand_sky_136050_1920x1080.jpg",
                SubTitle = "Creation and Development Group",
                Title = "Kredek"
            };

            ImageAndTextTemplateLeft = new ImageAndTextTemplate()
            {
                IsLeft = true,
                ImageUrl = "https://images.pexels.com/photos/1181271/pexels-photo-1181271.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                Title = "Tutaj bedzie krotki opis naszego kola",
                Text = "Nam cursus cursus enim, id tempor velit aliquet nec. Pellentesque tincidunt tortor et ex aliquam, eget lobortis nunc porta. Cras non tempor diam. Sed eu ullamcorper nulla. Quisque sodales dictum nisi. Praesent eget porttitor justo, ultricies gravida nisi. Maecenas vestibulum, est sit amet gravida fermentum, nisi mauris elementum ipsum, non vulputate neque libero a ipsum. Quisque pulvinar fringilla dui quis maximus. Cras ut luctus massa. Etiam porttitor quam et ligula laoreet eleifend. Nullam non elementum diam, vel placerat orci."
            };

            ImageAndTextTemplateRight = new ImageAndTextTemplate()
            {
                IsLeft = false,
                ImageUrl = "https://images.pexels.com/photos/574077/pexels-photo-574077.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                Title = "A tutaj nie bedzie krotki opis naszego kola",
                Text = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like)."
            };
        }
    }
}