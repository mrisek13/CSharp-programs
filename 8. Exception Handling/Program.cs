using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace OOP_Vj9
{
    class Program
    {
        //1.	Lista filmova
        static List<Film> Filmovi = new List<Film>();
        const string datotekaFilmova = "filmovi.json";

        static void Main(string[] args)
        {
            //8.	Učitati listu filmova kod pokretanja programa
            UcitajFilmove();

            Console.WriteLine("*************************");
            Console.WriteLine("     V I D E O T E K A   ");
            Console.WriteLine("*************************");

            string odabir = "";

            // koristimo do-while petlju da bi korisniku nudili izbornik tako dugo dok ne odabere X čime se
            // prekida petlja i aplikacija završava s radom
            do
            {
                //2.	Izbornik za pozivanje metoda
                Console.WriteLine("------------------------------");
                Console.WriteLine("Izbornik:");
                Console.WriteLine("1. Pregled filmova");
                Console.WriteLine("2. Unos filma");
                Console.WriteLine("3. Posudba filma");
                Console.WriteLine("4. Vraćanje filma");
                Console.WriteLine("5. Nabavka filma");
                Console.WriteLine("X. IZLAZ");

                Console.Write("Vaš odabir: ");
                // spremamo u varijablu odabir ono što je korisnik utipkao
                odabir = Console.ReadLine();

                Console.WriteLine("------------------------------");

                // pomoću switch uspoređujemo vrijednost varijable odabir i ovisnu o toj vrijednosti
                // pozivamo odgovarajuću metodu
                switch (odabir)
                {
                    case "1":
                        IspisiFilmove();
                        // pomoću break naredbe prekidamo daljnje izvršavanje switch bloka nakon ovog case bloka
                        // bez break naredbe izvršavanje bi se nastavilo i prošlo bi kroz sve naredbe koje dolaze
                        // nakon pronađenog case-a sve do kraja switch bloka ili do drugog case bloka koji ima break naredbu
                        break;
                    case "2":
                        UnosFilma();
                        break;
                    case "3":
                        PosudiFilm();
                        break;
                    case "4":
                        VratiFilm();
                        break;
                    case "5":
                        Nabavka();
                        break;
                    case "X":
                        break;
                    default:
                        Console.WriteLine("Pogrešan unos...");
                        break;

                }
            }
            // izbornik se nudi tako dugo dok korisnik ne odabere X
            while (odabir != "X");

            // prije izlaska iz aplikacije poziva se metoda koja listu filmova sprema u datoteku
            SpremiFilmove();
        }

        //3.	Metoda IspisiFilmove() – ispisuje sve filmove
        static void IspisiFilmove()
        {
            Console.WriteLine("POPIS FILMOVA:");

            //{0,-6} - definiramo da je širina 6 znakova, minus označava da će sadržaj biti poravnat ulijevo, ako je pozitivno onda je desno
            //više na https://learn.microsoft.com/en-us/dotnet/api/system.string.format?view=netframework-4.7.2

            Console.WriteLine("{0,-6}|{1,-50}|{2,10}|{3,10}", "OZNAKA", "NAZIV", "KOLIČINA", "SLOBODNO");

            foreach (Film f in Filmovi)
            {
                Console.WriteLine($"{f.Oznaka,-6}|{f.Naziv,-50}|{f.Kolicina,10}|{f.Slobodno,10}");
            }
        }

        //4.	Metoda UnosFilma() – unos podataka o filmu (oznaka, naziv, količina) i spremanje u listu
        static void UnosFilma()
        {
            Console.WriteLine("NOVI FILM:");
            Console.Write("Oznaka: ");
            string oznaka = Console.ReadLine();

            bool oznakaPostoji = false;

            // tražimo ako već postoji film s unešenom oznakom, šifrom
            foreach (Film f in Filmovi)
            {
                if (f.Oznaka == oznaka)
                {
                    oznakaPostoji = true;
                    break;
                }
            }

            // ako postoji film s istom oznakom onda ispisujemo poruku i prekidamo daljnje izvršavanje ove metode naredbom return;
            if (oznakaPostoji)
            {
                Console.WriteLine("Već postoji film s tom oznakom!");
                return;
            }

            Console.Write("Naziv: ");
            string naziv = Console.ReadLine();

            int kolicina = 0;

            bool unosOk = false;

            // Korisniku nudimo upis tako dugo dok ne unese broj, tj. dok se upisani tekst ne može pretvoriti u integer
            while (unosOk == false)
            {
                try
                {
                    Console.Write("Količina: ");
                    string kolicinaStr = Console.ReadLine();

                    // string pretvaramo u int - ovdje dolazi do iznimke ako se string ne može pretvoriti u integer
                    // npr ako je korisnik unio abc ova linija baca grešku koju onda lovi catch blok
                    kolicina = Convert.ToInt32(kolicinaStr);

                    // ako se string može pretvoriti u integer, tj. prethodna linija se uspješno izvršila
                    // onda postavljamo vrijednost varijable unosOk na true
                    // čime se prekida while petlja
                    unosOk = true;
                }
                catch (Exception e)
                {
                    // dolazi do greške pa ispisujemo odgovarajuću poruku
                    Console.WriteLine($"Unesite broj! Greška {e.Message}");
                }
            }

            // Kreiramo instancu razreda Film i preko konstruktora definiramo njegove vrijednosti
            Film film = new Film(oznaka, naziv, kolicina);

            // Kreiranu instancu dodajemo u listu filmova
            Filmovi.Add(film);
        }

        //5.	Metoda PosudiFilm() – posudba filma po oznaci
        static void PosudiFilm()
        {
            Console.WriteLine("POSUDBA FILMA:");
            Console.Write("Oznaka: ");
            string oznaka = Console.ReadLine();

            // metode DohvatiFilmPoOznaci i Posudba mogu izbaciti Exception pa ih lovimo try-catch blokom
            // npr. ne postoji film po nekoj oznaci ili nema slobodnih primjeraka filma za posudbu
            try
            {
                Film film = DohvatiFilmPoOznaci(oznaka);
                film.Posudba();
            }
            catch (Exception e)
            {
                // ispisujemo poruku o grešci
                Console.WriteLine(e.Message);
            }
        }

        static Film DohvatiFilmPoOznaci(string oznaka)
        {
            // u listi filmova tražimo ako postoji film s određenom oznakom
            foreach (Film f in Filmovi)
            {
                // pronašli smo film po oznaci pa ga vraćamo kao rezultat ove metode
                if (f.Oznaka == oznaka)
                {
                    return f;
                }
            }

            // ako ne postoji film s tom oznakom izbacujemo Exception s porukom
            throw new Exception("Ne postoji film s tom oznakom!");
        }

        //6.	Metoda VratiFilm() – vraćanje filma po oznaci
        static void VratiFilm()
        {
            Console.WriteLine("VRAĆANJE FILMA:");
            Console.Write("Oznaka: ");
            string oznaka = Console.ReadLine();

            // metode DohvatiFilmPoOznaci i Vrati mogu izbaciti Exception pa ih lovimo try-catch blokom
            // npr. ne postoji film po nekoj oznaci ili nema posuđenih primjeraka filma
            try
            {
                Film film = DohvatiFilmPoOznaci(oznaka);
                film.Vrati();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void Nabavka()
        {
            //UPUTE:
            //Unos oznake filma
            //Unos broja novih primjeraka

            //Pronaći film po oznaci (kao u metodi VratiFilm ili PosudiFilm)
            //Pozvati metodu Nabavka nad pronađenim filmom
        }

        //7.	Spremiti listu filmova u datoteku pri izlaska iz programa
        static void SpremiFilmove()
        {
            // za spremanje u tekstualni oblik koristimo Newtonsoft.Json biblioteku koja nam
            // listu filmova vraća u JSON formatu
            string json = JsonConvert.SerializeObject(Filmovi);

            // pozivom metode WriteAllText iz statičke klase File spremamo JSON dobiven prethodnom linijom
            // u datoteku koja je definirana u varijabli datotekaFilmova
            // datoteka se generira u folderu gdje je i aplikacija
            // Desni klikn na projekt s desne strane -> Open folder in file explorer
            // -> \bin\debug\filmovi.json
            File.WriteAllText(datotekaFilmova, json);
        }

        //8.	Metoda za učitavanje liste filmova iz datoteke, pokreće se na početku aplikacije
        static void UcitajFilmove()
        {
            // provjeravamo ako postoji datoteka s filmovima
            // koristimo statičku klasu File i metodu Exists koja nam vraća
            // true - datoteka postoji ili false - datoteka ne postoji
            if (File.Exists(datotekaFilmova))
            {
                // čitanje sadržaja datoteke ili konverzija učitanih podataka u listu filmova
                // može prouzročiti greške pa te linije koda stavljamo u try-catch blok
                // da ne koristimo try-catch i desi se greška kod učitavanja datoteke
                // aplikacija bi se srušila na samom početku
                try
                {
                    // učitavamo sadržaj datoteke u string varijablu json
                    // koristimo statičku klasu File i metodu ReadAllText
                    string json = File.ReadAllText(datotekaFilmova);

                    // deserijaliziramo tekstualni oblik u listu filmova
                    Filmovi = JsonConvert.DeserializeObject<List<Film>>(json);
                }
                catch (Exception e)
                {
                    // ako je došlo do greške u try bloku, ovdje ispisujemo o kakvoj grešci se radi
                    // e.Message vraća kratki opis greške
                    Console.WriteLine($"Greška kod učitavanja: {e.Message}");
                }
            }
        }
    }
}
