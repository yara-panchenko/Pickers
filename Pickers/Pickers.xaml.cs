using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pickers
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pickers : ContentPage
    {
        public Pickers()
        {
            InitializeComponent();
        }
        Image harju = new Image();
        Image hiiu = new Image();
        Image ida = new Image();
        Image jarve = new Image();
        Image joge = new Image();
        Image lae = new Image();
        Image laev = new Image();
        Image parnu = new Image();
        Image polva = new Image();
        Image rapla = new Image();
        Image saare = new Image();
        Image tartu = new Image();
        Image valga = new Image();
        Image vilja = new Image();
        Image voru = new Image();
        Entry _entry = new Entry();
        private void uezd_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = uezd.SelectedIndex;
            if (selectedIndex == 0)
            {
                city.SelectedIndex = 0;
                valga.Source = ImageSource.FromResource("Pickers.valga.png");
                _entry.Text = "Валгамаа (эст. Valgamaa или Валгаский уезд, Valga maakond) — уезд в Эстонии, расположенный в южной части страны. Административный центр — город Валга, расположенный на эстонско-латвийской границе и образующий с латвийским городом Валка по сути единый город, разделённый границей. Уезд состоит из двух городов (Валга и Тырва) и 11 волостей.";
            }
            else if (selectedIndex == 1)
            {
                city.SelectedIndex = 1;
                vilja.Source = ImageSource.FromResource("Pickers.vilja.png");
                _entry.Text = "Ви́льяндимаа (эст. Viljandimaa или Viljandi maakond) — уезд в Эстонии, расположенный в южной части страны. Административный центр — город Вильянди. Уезд состоит из трёх городов и 9 волостей.";
            }
            else if (selectedIndex == 2)
            {
                city.SelectedIndex = 2;
                voru.Source = ImageSource.FromResource("Pickers.voru.png");
                _entry.Text = "Вырумаа (эст. Võrumaa или Võru maakond, выруск. Võromaa или Võro maakund) — уезд в Эстонии, расположенный в юго-восточной части страны. Граничит с Россией, Латвией, уездами Валгамаа и Пылвамаа. Административный центр — город Выру (тж. Верро). Уезд в административном отношении делится на один город и 4 волости (с 2017 года).";
            }
            else if (selectedIndex == 3)
            {
                city.SelectedIndex = 3;
                ida.Source = ImageSource.FromResource("Pickers.ida.png");
                _entry.Text = "И́да-Ви́румаа (эст. Ida-Virumaa), или И́да-Ви́руский уезд (эст. Ida-Viru maakond) — уезд (мааконд) на северо-востоке Эстонии, граничит на севере и востоке с Россией. Территория уезда простирается до Финского залива на севере, до реки Нарвы на востоке и до Чудского озера на юге. На западе и юго-западе уезда граница тянется через леса и болота Алутагузе[2], вдоль территории Ляэне-Вируского и Йыгеваского уездов. Площадь Ида-Вирумаа — 3364,05 км², что составляет 7,4 % от площади всей Эстонии. В середине северной части уезда, в 165 км от Таллина, находится административный центр Ида-Вирумаа — город Йыхви.";
            }
            else if (selectedIndex == 4)
            {
                city.SelectedIndex = 4;
                joge.Source = ImageSource.FromResource("Pickers.joge.png");
                _entry.Text = "Йыгевамаа (эст. Jõgevamaa или Jõgeva maakond) — уезд в Эстонии, расположенный в восточной части страны. Административный центр — город Йыгева. Уезд в административном отношении делится на 3 города и 10 волостей.";
            }
            else if (selectedIndex == 5)
            {
                city.SelectedIndex = 5;
                laev.Source = ImageSource.FromResource("Pickers.laev.png");
                _entry.Text = "Ля́эне-Ви́румаа (эст. Lääne-Virumaa или Lääne-Viru maakond) — уезд в Эстонии, расположенный в северо-восточной части страны. Административный центр — город Раквере.";
            }
            else if (selectedIndex == 6)
            {
                city.SelectedIndex = 6;
                lae.Source= ImageSource.FromResource("Pickers.lae.png");
                _entry.Text = "Ляэнемаа (эст. Läänemaa или Lääne maakond) — уезд в Эстонии, расположенный на крайнем западе материковой части страны. С севера и запада омывается Балтийским морем. Граничит с уездами Харьюмаа на северо-востоке, Рапламаа на востоке и Пярнумаа на юге. Административный центр — город Хаапсалу. Уезд в административном отношении делится на 1 город и 9 волостей.";
            }
            else if (selectedIndex == 7)
            {
                city.SelectedIndex = 7;
                polva.Source = ImageSource.FromResource("Pickers.polva.png");
                _entry.Text = "Пы́лвамаа (старое написание Пыльвамаа; эст. Põlvamaa или Põlva maakond) — уезд на юго-востоке Эстонии. Граничит с Россией на востоке, а также с уездами Вырумаа, Валгамаа и Тартумаа. Административный центр — город Пылва. До административной реформы местных самоуправлений Эстонии 2017 года уезд делился на 13 волостей, после — на 3 волости.";
            }
            else if (selectedIndex == 8)
            {
                city.SelectedIndex = 8;
                parnu.Source = ImageSource.FromResource("Pickers.parnu.png");
                _entry.Text = "Пярнумаа (эст. Pärnumaa или Pärnu maakond) — самый крупный по площади уезд в Эстонии, расположенный в юго-западной части страны на побережье Рижского залива. Граничит с уездами Ляэнемаа и Рапламаа на севере и Ярвамаа и Вильяндимаа на востоке. Административный центр — город Пярну. Уезд в административном отношении делится на 2 города и 17 волостей.";
            }
            else if (selectedIndex == 9)
            {
                city.SelectedIndex = 9;
                rapla.Source = ImageSource.FromResource("Pickers.rapla.png");
                _entry.Text = "Рапламаа (эст. Raplamaa или Rapla maakond) — уезд в Эстонии, расположенный в западной части страны. Граничит с уездами Ярвамаа на востоке, Пярнумаа на юге, Ляэнемаа на западе и Харьюмаа на севере. Административный центр — город Рапла. Уезд в административном отношении делится на 10 волостей.";
            }
            else if (selectedIndex == 10)
            {
                city.SelectedIndex = 10;
                saare.Source = ImageSource.FromResource("Pickers.saare.png");
                _entry.Text = "Са́аремаа (эст. Saaremaa или Saare maakond) — уезд в Эстонии, территория которого состоит из островов Сааремаа, Муху, Абрука, Вилсанди, Рухну и других более мелких островов.";
            }
            else if (selectedIndex == 11)
            {
                city.SelectedIndex = 11;
                tartu.Source = ImageSource.FromResource("Pickers.tartu.png");
                _entry.Text = "Та́ртумаа (также Та́ртуский уе́зд — эст. Tartu maakond) — один из 15 уездов Эстонской Республики. Административный центр — город Тарту. Площадь — 2993 км², население — 153 479 (2012).";
            }
            else if (selectedIndex == 12)
            {
                city.SelectedIndex = 12;
                harju.Source = ImageSource.FromResource("Pickers.harju.png");
                _entry.Text = "Харьюмаа, или Харью (эст. Harju maakond или Harjumaa), — один из 15 уездов Эстонии. Административный центр — столица страны Таллин. С 21 декабря 2009 года старейшина уезда — Юлле Раясалу (Ülle Rajasalu).";
            }
            else if (selectedIndex == 13)
            {
                city.SelectedIndex = 13;
                hiiu.Source = ImageSource.FromResource("Pickers.hiiu.png");
                _entry.Text = "Хийумаа (эст. Hiiu maakond) — уезд в Эстонии, территория которого состоит из острова Хийумаа и окружающих его малых островов.Административный центр уезда — город Кярдла.";
            }
            else if (selectedIndex == 14)
            {
                city.SelectedIndex = 14;
                jarve.Source = ImageSource.FromResource("Pickers.jarve.png");
                _entry.Text = "Ярвамаа (эст. Järvamaa или Järva maakond) — уезд в Эстонии, расположенный в центральной части страны. Административный центр — город Пайде. Уезд в административном отношении делится на один городской муниципалитет и две волости.";
            }
        }

        private void city_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex1 = city.SelectedIndex;
            if (selectedIndex1 == 0)
            {
                uezd.SelectedIndex = 0;
                //valga.Source = ImageSource.FromResource("Pickers.valga.png");
            }
            else if (selectedIndex1 == 1)
            {
                uezd.SelectedIndex = 1;
                //vilja.Source = ImageSource.FromResource("Pickers.vilja.png");
            }
            else if (selectedIndex1 == 2)
            {
                uezd.SelectedIndex = 2;
                //voru.Source = ImageSource.FromResource("Pickers.voru.png");
            }
            else if (selectedIndex1 == 3)
            {
                uezd.SelectedIndex = 3;
                //ida.Source = ImageSource.FromResource("Pickers.ida.png");
            }
            else if (selectedIndex1 == 4)
            {
                uezd.SelectedIndex = 4;
                //joge.Source = ImageSource.FromResource("Pickers.joge.png");
            }
            else if (selectedIndex1 == 5)
            {
                uezd.SelectedIndex = 5;
                //laev.Source = ImageSource.FromResource("Pickers.laev.png");
            }
            else if (selectedIndex1 == 6)
            {
                uezd.SelectedIndex = 6;
                //lae.Source = ImageSource.FromResource("Pickers.lae.png");
            }
            else if (selectedIndex1 == 7)
            {
                uezd.SelectedIndex = 7;
                //polva.Source = ImageSource.FromResource("Pickers.polva.png");
            }
            else if (selectedIndex1 == 8)
            {
                uezd.SelectedIndex = 8;
                //parnu.Source = ImageSource.FromResource("Pickers.parnu.png");
            }
            else if (selectedIndex1 == 9)
            {
                uezd.SelectedIndex = 9;
                //rapla.Source = ImageSource.FromResource("Pickers.rapla.png");
            }
            else if (selectedIndex1 == 10)
            {
                uezd.SelectedIndex = 10;
                //saare.Source = ImageSource.FromResource("Pickers.saare.png");
            }
            else if (selectedIndex1 == 11)
            {
                uezd.SelectedIndex = 11;
                //tartu.Source = ImageSource.FromResource("Pickers.tartu.png");
            }
            else if (selectedIndex1 == 12)
            {
                uezd.SelectedIndex = 12;
                //harju.Source = ImageSource.FromResource("Pickers.harju.png");
            }
            else if (selectedIndex1 == 13)
            {
                uezd.SelectedIndex = 13;
                //hiiu.Source = ImageSource.FromResource("Pickers.hiiu.png");
            }
            else if (selectedIndex1 == 14)
            {
                uezd.SelectedIndex = 14;
                //jarve.Source = ImageSource.FromResource("Pickers.jarve.png");
            }
        }
    }
}