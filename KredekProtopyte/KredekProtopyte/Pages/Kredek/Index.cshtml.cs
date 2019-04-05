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
            PageContent = new PageContent();
            //CreateNewRazorPage();

            // TODO : add DbContext And Users registration, facebook authentication, etc.
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