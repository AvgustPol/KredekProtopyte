using KredekProtopyte.Data;
using KredekProtopyte.Data.Templates;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KredekProtopyte.Pages.Kredek
{
    public class CourseModel : PageModel
    {
        public PageContent PageContent { get; set; }

        public void OnGet()
        {
            PageContent = new PageContent();

            string textInfo0 = "Informacje ogólne";
            string textInfo1 = "Kurs rozpoczniemy od zajęć umożliwiających poznanie środowiska Visual Studio oraz narzędzi, z których będziemy korzystać w trakcie kursu. Przedstawione zostaną informacje na temat składni języka, słów kluczowych oraz konstrukcji występujących w języku C#. Już po pierwszych zajęciach nie będą Ci obce elementy takie jak: zmienne, pętle, funkcje,operatory, komentarze i wiele innych.";
            string textInfo2 = "Kolejne zajęcia pozwolą Wam na zdobycie wiedzy z zakresu programowania obiektowego, z którego będziemy korzystać przez resztę kursu. Zaznajomimy się między innymi z klasami, interfejsami, metodami, dziedziczeniem, polimorfizmem, hermetyzacją.";
            string textInfo3 = "Podczas kolejnych spotkań nauczymy się podłączać nasze aplikacje do bazy danych oraz pracować na danych z nich pozyskanych. Kolejne zajęcia dostarczą nam wiedzy na temat aplikacji webowych i wielu przydatnych narzędzi programistycznych wraz z dużą ilością dobrych praktyk i przykładów ich wykorzystania.";
            string textInfo4 = "Brzmi ciekawie? Nie zwlekaj z decyzją i weź udział w naszym kursie, czekamy na Ciebie.";

            string textFAQ = "";
            string textFAQ1 = "Jak się zapisać na kurs?";
            string answeredFAQ1 = "Zapisy na nasz kurs odbywają się poprzez formularz zgłoszeniowy który zostanie umieszczony na naszej stronie FB (można dodać odnośnik) w dniu zapisów. O dokładnym terminie zapisów będziemy wielokrotnie przypominać z odpowiednim wyprzedzeniem.";

            string textFAQ2 = "Co ile odbywają się zajęcia?";
            string answeredFAQ2 = "Zajęcia odbywają się cyklicznie co tydzień. W razie gdy pokrywają się one ze świętami czy innymi dniami wolnymi od zajęć na uczelni zajęcia również nie odbywają się, a temat z opuszczonych zajęć jest prezentowany na kolejnych.";

            string textFAQ3 = "Czy ilość miejsc na kursie jest ograniczona?";
            string answeredFAQ3 = "Tak, ilość miejsc jest ograniczona dlatego zalecamy aby nie zwlekać z zapisami na kurs na aż do ostatniej chwili.";

            string textFAQ4 = "Jaką wiedzę należy posiadać aby wziąć udział w kursie?";
            string answeredFAQ4 = "Zalecana jest podstawowa wiedza z zakresu programowania (najlepiej obiektowego).";

            string textFAQ5 = "Czy kurs jest całkowicie darmowy?";
            string answeredFAQ5 = "Tak, kurs jest całkowicie wolny od jakichkolwiek opłat.";

            string textFAQ6 = "Co jest potrzebne aby wziąć udział w kursie?";
            string answeredFAQ6 = "Do udziału w zajęciach potrzebny jest laptop z zainstalowanym odpowiednim oprogramowaniem (Visual Studio itp. o którym zawsze odpowiednio wcześnie informujemy przed zajęciami). Przydatne są również przedłużacze w przypadku gdy wiemy, że nasz sprzęt nie wytrzyma 2h pracy na baterii.";

            string dyplomImg = "http://kredek.iiar.pwr.edu.pl/img/ogloszenia/egzamin-CPC-2018-2/certyfikaty/2018-2_1_Dominik_Frankowski_wm.png";
            string dyplomAlt = "Gratulacje dla Dominika Frankowskiego, który uzyskał‚ najwyższy wynik spośród 25 uczestników Egzaminu CPC Edycja 2018-2";

            PageContent.Elements.Add(new BannerTemplate()
            {
                ImageUrl = "https://images.wallpaperscraft.com/image/desert_sand_sky_136050_1920x1080.jpg",
                SubTitle = "Creation and Development Group",
                Title = "Kredek"
            });
        }
    }
}