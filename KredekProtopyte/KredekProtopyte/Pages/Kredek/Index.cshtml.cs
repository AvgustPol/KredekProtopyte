using KredekProtopyte.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Diagnostics;
using System.IO;

namespace KredekProtopyte.Pages.Kredek
{
    public class IndexModel : PageModel
    {
        public PageContent PageContent { get; set; }
        public string PageName { get; set; } = "MyNewTestPage";

        public void CreateNewRazorPage()
        {
            //TODO why it is not working? It doesnt create a new file. Maybe this code is for copying only directories .
            string SourcePath = @"D:\Programming\CMS\KredekProtopyte\KredekProtopyte\KredekProtopyte\Pages\Template";
            string DestinationPath = $@"D:\Programming\CMS\KredekProtopyte\KredekProtopyte\KredekProtopyte\Pages\{PageName}";

            CopyFolderContents(SourcePath, DestinationPath);

            ////Now Create all of the directories
            //foreach (string dirPath in Directory.GetDirectories(SourcePath, "*",
            //    SearchOption.AllDirectories))
            //    Directory.CreateDirectory(dirPath.Replace(SourcePath, DestinationPath));

            ////Copy all the files & Replaces any files with the same name
            //foreach (string newPath in Directory.GetFiles(SourcePath, "*.*",
            //    SearchOption.AllDirectories))
            //    System.IO.File.Copy(newPath, newPath.Replace(SourcePath, DestinationPath), true);
        }

        public void OnGet()
        {
            //CreateNewRazorPage();

            // TODO : add DbContext And Users registration, facebook authentication, etc.
            PageContent = new PageContent();

            PageContent.Elements.Add(new BannerTemplate()
            {
                ImageUrl = "https://images.wallpaperscraft.com/image/desert_sand_sky_136050_1920x1080.jpg",
                SubTitle = "Creation and Development Group",
                Title = "Kredek"
            });

            PageContent.Elements.Add(new ImageAndTextTemplate()
            {
                IsLeft = true,
                ImageUrl = "https://images.pexels.com/photos/1181271/pexels-photo-1181271.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                Title = "Tutaj bedzie krotki opis naszego kola",
                Text = "Nam cursus cursus enim, id tempor velit aliquet nec. Pellentesque tincidunt tortor et ex aliquam, eget lobortis nunc porta. Cras non tempor diam. Sed eu ullamcorper nulla. Quisque sodales dictum nisi. Praesent eget porttitor justo, ultricies gravida nisi. Maecenas vestibulum, est sit amet gravida fermentum, nisi mauris elementum ipsum, non vulputate neque libero a ipsum. Quisque pulvinar fringilla dui quis maximus. Cras ut luctus massa. Etiam porttitor quam et ligula laoreet eleifend. Nullam non elementum diam, vel placerat orci."
            });

            PageContent.Elements.Add(new ImageAndTextTemplate()
            {
                IsLeft = false,
                ImageUrl = "https://images.pexels.com/photos/574077/pexels-photo-574077.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                Title = "A tutaj nie bedzie krotki opis naszego kola",
                Text = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like)."
            });
        }

        private bool CopyFolderContents(string SourcePath, string DestinationPath)
        {
            SourcePath = SourcePath.EndsWith(@"\") ? SourcePath : SourcePath + @"\";
            DestinationPath = DestinationPath.EndsWith(@"\") ? DestinationPath : DestinationPath + @"\";

            try
            {
                if (Directory.Exists(SourcePath))
                {
                    if (Directory.Exists(DestinationPath) == false)
                    {
                        Directory.CreateDirectory(DestinationPath);
                    }

                    foreach (string files in Directory.GetFiles(SourcePath))
                    {
                        FileInfo fileInfo = new FileInfo(files);
                        fileInfo.CopyTo(string.Format(@"{0}\{1}", DestinationPath, fileInfo.Name), true);
                    }

                    foreach (string drs in Directory.GetDirectories(SourcePath))
                    {
                        DirectoryInfo directoryInfo = new DirectoryInfo(drs);
                        if (CopyFolderContents(drs, DestinationPath + directoryInfo.Name) == false)
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("");
                Debug.WriteLine($"Error: {ex.Message}");
                Debug.WriteLine("");

                return false;
            }
        }
    }
}