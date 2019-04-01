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
                IsLeft = false,
                ImageUrl = "https://images.pexels.com/photos/574077/pexels-photo-574077.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                Title = "Krotki opis naszego koła",
                Text = "Koło naukowe \"Kredek\" zostało założone dnia 1 Marca 2007. " +
                       "Co semestr uruchamiamy kolejną edycję, podczas której z ambitnych studentów robimy profesjonalnych informatyków." +
                       "Celem Koła Naukowego jest poznawanie nowych technologii programistycznych, umiejętności przydatnych w przyszłej karierze zawodowej " +
                       "oraz uczenie się od siebie nawzajem. " +
                       "Nasze założenia realizujemy poprzez spotkania, wykłady, laboratoria oraz wspólne projekty."
            });

            PageContent.Elements.Add(new ImageAndTextTemplate()
            {
                IsLeft = true,
                ImageUrl = "https://images.pexels.com/photos/1181271/pexels-photo-1181271.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                Title = "Krótki opis kursu",
                Text = "Nasz kurs powstał z myślą o osobach początkujących, które chciałyby zdobyć wiedzę z zakresu programowania w języku C# " +
                       "oraz innych technologii pozwalających na budowanie nowoczesnych i responsywnych aplikacji. " +
                       "W trakcie kursu będziesz wraz z prowadzącymi budować kolejne aplikacje " +
                       "oraz przyswajać wiele przydatnych wskazówek i dobrych praktyk. " +
                       "Każde zajęcia będą zwieńczone zadaniem domowym umożliwiającym ugruntowanie zdobytej wiedzy " +
                       "i wykazanie się kreatywnością. " +
                       "Kurs kończy się egzaminem którego zdanie gwarantuje otrzymanie certyfikatu dokumentującego uzyskane umiejętności"
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