using KredekProtopyte.Data;
using KredekProtopyte.Data.Templates;
using KredekProtopyte.Data.Website;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;

namespace KredekProtopyte.Pages
{
    public class IndexModel : PageModel
    {
        public WebsitePage ThisPage { get; set; }

        //https://localhost:44393/?pageName=About working
        //https://localhost:44393/?page=About -> page = /Index
        public void OnGet(string pageName = "Home")
        {
            if (pageName == "Home")
            {
                ThisPage = CreateHomeStaticPage();
            }
            else if (pageName == "About")
            {
                ThisPage = CreateAboutStaticPage();
            }
            else if (pageName == "Team")
            {
                ThisPage = CreateTeamStaticPage();
            }
            else
            {
                //Default version for wrong adress
                ThisPage = CreateHomeStaticPage();
            }
        }

        #region Tmp Static Data

        private WebsitePage CreateAboutStaticPage()
        {
            var pageIntro = new WebsitePage()
            {
                Name = "About",
                Title = "O Nas",
                Content = new PageContent()
                {
                    Elements = new List<IPageContentElement>()
                    {
                        new WeAreWorkingOnIt()
                    }
                }
            };
            return pageIntro;
        }

        private WebsitePage CreateBlogStaticPage()
        {
            throw new NotImplementedException();
            var pageIntro = new WebsitePage()
            {
                Name = "Blog",
                Title = "Blog",
                Content = new PageContent()
                {
                    Elements = new List<IPageContentElement>()
                    {
                    }
                }
            };
            return pageIntro;
        }

        private WebsitePage CreateHomeStaticPage()
        {
            var pageIntro = new WebsitePage()
            {
                Name = "Home",
                Title = "Strona główna ",
                Content = new PageContent()
                {
                    Elements = new List<IPageContentElement>()
                    {
                        new BannerTemplate()
                        {
                            ImageUrl = "../img/bannerIntro.jpg",
                            SubTitle = "Creation and Development Group",
                            Title = "KREDEK"
                        },

                        new ImageAndTextTemplate()
                        {
                            IsLeft = false,
                            ImageUrl =
                                "https://images.pexels.com/photos/574077/pexels-photo-574077.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                            Title = "Nasze koło",
                            Text = "Koło naukowe \"Kredek\" zostało założone dnia 1 Marca 2007. " +
                                   "Co semestr uruchamiamy kolejną edycję, podczas której z ambitnych studentów robimy profesjonalnych informatyków. " +
                                   "Celem Koła Naukowego jest poznawanie nowych technologii programistycznych, umiejętności przydatnych w przyszłej karierze zawodowej " +
                                   "oraz uczenie się od siebie nawzajem. " +
                                   "Nasze założenia realizujemy poprzez spotkania, wykłady, laboratoria oraz wspólne projekty."
                        },

                        new ImageAndTextTemplate()
                        {
                            IsLeft = true,
                            ImageUrl =
                                "https://images.pexels.com/photos/1181271/pexels-photo-1181271.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                            Title = "Nasz kurs",
                            Text =
                                "Nasz kurs powstał z myślą o osobach początkujących, które chciałyby zdobyć wiedzę z zakresu programowania w języku C# " +
                                "oraz innych technologii pozwalających na budowanie nowoczesnych i responsywnych aplikacji. " +
                                "W trakcie kursu będziesz wraz z prowadzącymi budować kolejne aplikacje " +
                                "oraz przyswajać wiele przydatnych wskazówek i dobrych praktyk. " +
                                "Każde zajęcia będą zwieńczone zadaniem domowym umożliwiającym ugruntowanie zdobytej wiedzy " +
                                "i wykazanie się kreatywnością. " +
                                "Kurs kończy się egzaminem, którego zdanie gwarantuje otrzymanie certyfikatu dokumentującego uzyskane umiejętności."
                        },

                        new BannerTextAndLinks()
                    }
                }
            };
            return pageIntro;
        }

        private WebsitePage CreateTeamStaticPage()
        {
            var pageIntro = new WebsitePage()
            {
                Name = "Team",
                Title = "Zespół",
                Content = new PageContent()
                {
                    Elements = new List<IPageContentElement>()
                    {
                        new FullWidthBanner() {BackgroundImageUrl = "../img/bannerTeam.jpg", Text = "Nasz zespół " },
                        new Team()
                    }
                }
            };
            return pageIntro;
            //{ BackgroundImageUrl = "../img/bannerTeam.jpg", Text = "Nasz zespół " }
        }

        #endregion Tmp Static Data
    }
}