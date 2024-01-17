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

namespace OOP_Vj11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //enum tip podatka za dostupne računske operacije
        enum Operacija
        {
            Zbrajanje, Oduzimanje, Mnozenje, Dijeljenje
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        // Metoda koja se izvršava klikom na button Zbroji
        private void btnZbroji_Click(object sender, RoutedEventArgs e)
        {
            // pokrećemo metodu Izracunaj s vrijednošću enum tipa Operacija.Zbrajanje
            Izracunaj(Operacija.Zbrajanje);
        }

        // Metoda koja se izvršava klikom na button Oduzmi
        private void btnOduzmi_Click(object sender, RoutedEventArgs e)
        {
            Izracunaj(Operacija.Oduzimanje);
        }

        // Metoda koja se izvršava klikom na button Pomnozi
        private void btnPomnozi_Click(object sender, RoutedEventArgs e)
        {
            Izracunaj(Operacija.Mnozenje);
        }

        // Metoda koja se izvršava klikom na button Podijeli
        private void btnPodijeli_Click(object sender, RoutedEventArgs e)
        {
            Izracunaj(Operacija.Dijeljenje);
        }

        // Metoda koja se izvršava klikom na button Ponisti
        private void btnPonisti_Click(object sender, RoutedEventArgs e)
        {
            txtPrviBroj.Text = "";
            txtDrugiBroj.Text = "";
            txtRezultat.Text = "";
        }

        // Metoda koja se izvršava klikom na button Izlaz
        private void btnIzlaz_Click(object sender, RoutedEventArgs e)
        {
            // postavljamo pitanje koristeći klasu MessageBox i metodu Show
            // rezultat, ono što korisnik odabere, spremamo u varijablu tipa MessageBoxResult
            // prikazujemo poruku obavijesti s parametrima: tekst poruke, naslov poruke, vrsta buttona (odabir Yes / No), vrsta ikone
            MessageBoxResult result = MessageBox.Show("Jeste li sigurni?", "Upozorenje", MessageBoxButton.YesNo, MessageBoxImage.Question);

            // provjeravamo ako je korisnik kliknuo na Yes
            if (result == MessageBoxResult.Yes)
            {
                this.Close();
            }
        }
        private void Izracunaj(Operacija op)
        {
            // Provjeravamo ako je polje za prvi broj prazno
            // metoda IsNullOrWhiteSpace klase String vraća true ako je vrijednost nekog stringa prazna
            if (String.IsNullOrWhiteSpace(txtPrviBroj.Text))
            {
                // ako je prikazujemo poruku obavijesti da je potrebno upisati prvi broj
                MessageBox.Show("Upišite prvi broj!");
                // zaustavljamo daljnje izvršavanje metode
                return;
            }

            // Provjeravamo ako je polje za drugi broj prazno
            if (String.IsNullOrWhiteSpace(txtDrugiBroj.Text))
            {
                MessageBox.Show("Upišite drugi broj!");
                return;
            }

            double prviBroj;
            double drugiBroj;

            // parsiramo string u broj koristeći double.Parse što može preurokovati iznimku ako se string ne može pretvoriti u broj
            // pa koristimo try-catch izraz kako bi ulovili tu iznimku i prikazali upozorenje
            try
            {
                prviBroj = double.Parse(txtPrviBroj.Text);
            }
            catch (Exception es)
            {
                // prikazujemo poruku obavijesti s parametrima: tekst poruke, naslov poruke, vrsta buttona, vrsta ikone
                MessageBox.Show($"Vrijednost u polju Prvi broj nije broj! {es.Message}", "Upozorenje", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // parsiramo sadržaj polja Drugi broj koje je tipa string u double tip podatka
            // koristimo metodu TryParse koja vraća true ako može pretvoriti string u broj ili false ako ne može
            // metoda ima 2 parametra: string koji se pretvara u broj i varijablu u koju će spremiti broj - koristi se ključna riječ out
            if (double.TryParse(txtDrugiBroj.Text, out drugiBroj) == false)
            {
                MessageBox.Show("Vrijednost u polju Drugi broj nije broj!", "Upozorenje", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            double rezultat = 0;

            // ovisno o ulaznom parametru izvršavamo određenu računsku operaciju i spremamo rezultat u varijablu rezultat
            if (op == Operacija.Zbrajanje)
                rezultat = prviBroj + drugiBroj;
            else if (op == Operacija.Oduzimanje)
                rezultat = prviBroj - drugiBroj;
            else if (op == Operacija.Mnozenje)
                rezultat = prviBroj * drugiBroj;
            else
                rezultat = prviBroj / drugiBroj;

            // vrijednost varijable rezultat spremamo u text box za prikaz rezultata kroz property Text
            txtRezultat.Text = rezultat.ToString();
        }
    }
}
