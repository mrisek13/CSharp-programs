using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Poziv metode za prikaz izbornika
            meni();
        }

        static void meni()
        {
            while (true)
            {
                Console.WriteLine("╔═════════════════════════════╗");
                Console.WriteLine("║         IZBORNIK            ║");
                Console.WriteLine("║─────────────────────────────║");
                Console.WriteLine("║ 1) Ispis dana               ║");
                Console.WriteLine("║ 2) Unos podataka o studentu ║");
                Console.WriteLine("║ 3) Usporedba 2 broja        ║");
                Console.WriteLine("║ 4) Izračun katete trokuta   ║");
                Console.WriteLine("║ 5) Suma i prosjek N brojeva ║");
                Console.WriteLine("║ 6) Ispis parnih brojeva     ║");
                Console.WriteLine("║ X) Izlaz iz programa        ║");
                Console.WriteLine("╚═════════════════════════════╝");
                Console.Write("Odaberite opciju: ");


                string odabir = Console.ReadLine();

                if (odabir.ToLower() == "x")
                {
                    // Korisnik je odabrao izlaz iz programa
                    break;
                }

                // Ovdje možete implementirati odgovarajuće akcije za svaku opciju
                switch (odabir)
                {
                    case "1":
                        // Implementirajte akciju za opciju 1
                        Console.WriteLine("Odabrali ste ispis dana.");
                        ispisDana();
                        break;

                    case "2":
                        // Implementirajte akciju za opciju 2
                        Console.WriteLine("Odabrali ste unos podataka o studentu.");
                        unosStudenta();
                        break;

                    case "3":
                        // Implementirajte akciju za opciju 3
                        Console.WriteLine("Odabrali ste usporedbu 2 broja.");
                        usporedbaBrojeva();
                        break;

                    case "4":
                        // Implementirajte akciju za opciju 4
                        Console.WriteLine("Odabrali ste izračun katete trokuta.");
                        katetaTrokuta();
                        break;

                    case "5":
                        // Implementirajte akciju za opciju 5
                        Console.WriteLine("Odabrali ste sumu i prosjek N brojeva.");
                        sumaProsjek();
                        break;

                    case "6":
                        // Implementirajte akciju za opciju 6
                        Console.WriteLine("Odabrali ste ispis parnih brojeva.");
                        ispisParnihBrojeva();
                        break;

                    default:
                        Console.WriteLine("Nepoznata opcija. Molimo odaberite ispravnu opciju.");
                        break;
                }
            }
        }

        /// <summary>
        /// 6.	Unos n brojeva u polje tipa double nakon čega ispisati sve parne brojeve iz tog polja
        /// </summary>
        private static void ispisParnihBrojeva()
        {
            int brojeva;
            Console.Write("Brojeva: ");
            brojeva = Convert.ToInt32(Console.ReadLine());
            double[] brojevi = new double[brojeva];

            for (int i = 0; i < brojevi.Length; i++)
            {
                Console.Write($"{i + 1}. Broj: ");
                brojevi[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.Write("Parni brojevi: ");
            foreach (double broj in brojevi)
            {
                //ako je ostatak dijeljenja broja sa 2 jednako 0
                if (broj % 2 == 0)
                    Console.Write(broj + " ");
            }
        }

        /// <summary>
        /// //5.	Unos n brojeva u polje tipa double nakon čega ispisati sumu svih brojeva i njihov prosjek
        /// </summary>
        private static void sumaProsjek()
        {
            int brojeva;
            Console.Write("Brojeva: ");
            brojeva = Convert.ToInt32(Console.ReadLine());

            //dinamički alociramo polje od N elemenata
            double[] brojevi = new double[brojeva];

            for (int i = 0; i < brojeva; i++)
            {
                Console.Write($"{i + 1}. Broj: ");
                double br = Convert.ToDouble(Console.ReadLine());
                brojevi[i] = br;
            }

            double suma = 0;

            //foreach petlja se koristi za iteraciju kroz elemente neke kolekcije podataka
            //jednostavnija za korištenje od for petlje
            //sintaksa: foreach(<tip podatka> <iteracijska varijabla> in <kolekcija>)
            foreach (double broj in brojevi)
            {
                suma += broj;
            }

            double prosjek = suma / brojeva;
            Console.WriteLine($"Brojeva: {brojeva} Suma: {suma} Prosjek: {prosjek}");
        }

        /// <summary>
        /// 4.	Unos dužina stranica A i B trokuta te izračun hipotenuze korištenjem Math biblioteke
        /// </summary>
        private static void katetaTrokuta()
        {
            double strA, strB, strC;
            Console.Write("Stranica a: ");
            strA = Convert.ToDouble(Console.ReadLine());
            Console.Write("Stranica b: ");
            strB = Convert.ToDouble(Console.ReadLine());

            //Koristimo Math biblioteku za izračune
            strC = Math.Sqrt(Math.Pow(strA, 2) + Math.Pow(strB, 2));
            Console.WriteLine("Hipotenuza: " + strC);
        }

        /// <summary>
        /// 3.	Unos 2 broja te pomoću ternarnog operatora provjerite ako je prvi broj veći od drugog
        /// </summary>
        private static void usporedbaBrojeva()
        {
            double x, y;
            Console.Write("x: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("y: ");
            y = Convert.ToDouble(Console.ReadLine());

            //sintaksa: izraz koji može biti true ili false ? vraćamo ako je true : vraćamo ako je false
            string usporedba = x > y ? "x je veći od y" : "x nije veći od y";

            //kompleksniji primjer sa ugnježdenim ternarnim operatorom
            string usporedba2 = x > y ? //izraz koji vraća true ili false
                                "x je veći od y" : //vraćamo ako je izraz true
                                x == y ? //ako je izraz false onda idemo na ugnježdeni izraz koji provjerava ako su vrijednosti jednake
                                    "x je jednak y" : //vraćamo ako je izraz true
                                    "y je veći od x"; //vraćamo ako je izraz false

            Console.WriteLine(usporedba2);
        }

        /// <summary>
        /// 2.	Unos podataka o studentu: prezime i ime, godina studija, smjer nakon čega iste podatke ispisati 
        /// u obliku Student prezime i ime polazi godinu. godinu smjera smjer
        /// </summary>
        private static void unosStudenta()
        {
            string prezimeIme, smjer;
            int godina;

            Console.Write("Prezime i ime: ");
            prezimeIme = Console.ReadLine();
            Console.Write("Smjer: ");
            smjer = Console.ReadLine();
            Console.Write("Godina: ");
            godina = Convert.ToInt32(Console.ReadLine());

            //a.	Spajanje stringova i varijabli operatorom +
            string opisA = "Student " + prezimeIme + " polazi " + godina + ". godinu smjera " + smjer;
            Console.WriteLine(opisA);

            //b.	Koristeći String.Format - ubacujemo vrijednosti varijabli u drugi string
            // Prvi argument funkcije String.Format je string koji želimo vratiti,
            // drugi argument je polje vrijednosti koje želimo ubaciti u taj string
            // vrijednosti { } su placeholderi koji počinju 
            // s indeksom 0 a na to mjesto će doći prvi argument prosljeđen u tu metodu - prezimeIme, na {1} drugi argument...
            // tj. na {0} ide vrijednost varijable prezimeIme, na {1} vrijednost varijable godina...                
            string opisB = String.Format("Student {0} polazi {1}. godinu smjera {2}", prezimeIme, godina, smjer);
            Console.WriteLine(opisB);

            //c.	Koristeći String interpolation
            // koristimo znak $ prije " što omogućava da unutar stringa ispisujemo vrijednosti varijabli unutar {}
            string opisC = $"Student {prezimeIme} polazi {godina}. godinu smjera {smjer}";
            Console.WriteLine(opisC);
        }

        /// <summary>
        /// 1. Unos rednog broja dana u tjednu(1 - 7) nakon čega se ispisuje taj dan u tjednu, 
        /// npr. za unos 3 ispisati Srijeda, ukoliko korisnik unese neki drugi broj koji nije
        /// u rasponu od 1 do 7 ponovno ponuditi upis
        /// </summary>
        private static void ispisDana()
        {
            //Kreiramo string polje sa nazivima dana u tjednu
            string[] daniUTjednu = { "Ponedjeljak", "Utorak", "Srijeda", "Četvrtak",
                    "Petak", "Subota", "Nedjelja"};

            int broj;

            //pomoću do-while petlje korisniku nudimo upis broja tako dugo dok je njegov unos manji od 1 a veći od 7
            do
            {
                Console.Write("Broj 1-7: ");
                //pretvaramo korisnički unos u cijeli broj pomoću Convert.ToInt32() naredbe
                broj = Convert.ToInt32(Console.ReadLine());
            } while (broj < 1 || broj > 7);

            Console.WriteLine("Odabrani dan: " + daniUTjednu[broj - 1]);
        }
    }
}
