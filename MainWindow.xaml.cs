using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NET_ININ4_PR2._2_z2
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new Dane();
        }
        class Dane
        {
            public string JakiśNapis { get; set; } = "wartość początkowa";
            //tablica jednowymiarowa - jako-tako użyteczna z ListBoxem, praktycznie bezużyteczna z DataGridem
            public string[] JakaśTablica { get; set; } = new string[]
            {
                "Adam",
                "Beata",
                "Cyprian",
                "Danuta",
                "Edward",
                "Fiona"
            };
            //ListBox wyświetli krotkę w nawiasach, nie mamy możliwości formatowania
            //DataGrid - bezużyteczna
            public (string Imię, string Nazwisko)[] JakaśTablica2 { get; set; } = new (string Imię, string Nazwisko)[]
            {
                ("Adam","Wiśniewski"),
                ("Beata","Jabłońska"),
                ("Cyprian","Sosnowski"),
                ("Danuta","Dąbrowska"),
                ("Edward","Topolski"),
                ("Fiona","Lipowicz")
            };
            //tablica dwuwymiarowa - literalnie bezużyteczna do wiązania
            public string[,] JakaśTablica3 { get; set; } = new string[,]
            {
                { "Adam","Wiśniewski" },
                { "Beata","Jabłońska" },
                { "Cyprian","Sosnowski" },
                { "Danuta","Dąbrowska" },
                { "Edward","Topolski" },
                { "Fiona","Lipowicz" }
            };
            //tablica tablic - praktycznie bezużyteczna do wiązania
            public string[][] JakaśTablica4 { get; set; } = new string[][]
            {
                new string[] { "Adam","Wiśniewski" },
                new string[] { "Beata","Jabłońska" },
                new string[] { "Cyprian","Sosnowski" },
                new string[] { "Danuta","Dąbrowska" },
                new string[] { "Edward","Topolski" },
                new string[] { "Fiona","Lipowicz" }
            };
            //tablica korzysta z klasy, której instancje mają właściwości, które możemy bindować
            //będzie dobrze współpracować zarówno z DataGrid-em jak i ListBox-em
            public Osoba[] JakaśTablica5 { get; set; } = new Osoba[]
            {
                new Osoba() { Imię="Adam", Nazwisko="Wiśniewski" },
                new Osoba() { Imię="Beata", Nazwisko="Jabłońska" },
                new Osoba() { Imię="Cyprian", Nazwisko="Sosnowski" },
                new Osoba() { Imię="Danuta", Nazwisko="Dąbrowska" },
                new Osoba() { Imię="Edward", Nazwisko="Topolski" },
                new Osoba() { Imię="Fiona", Nazwisko="Lipowicz" }
            };

            public class Osoba
            {
                public string Imię { get; set; }
                public string Nazwisko { get; set; }
                public override string ToString()
                {
                    return Imię+" "+Nazwisko;
                }
            }
        }
    }
}
