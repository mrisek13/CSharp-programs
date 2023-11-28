using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Vj8
{
    //1.	Enumeracija VrstaNaselja
    enum VrstaNaselja
    {
        Selo, Grad
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Zupanija> zupanije = new List<Zupanija>();

            Naselje n1 = new Naselje("Čakovec", 15147, VrstaNaselja.Grad);

            Naselje n2 = new Naselje("Prelog", 7781, VrstaNaselja.Grad);
            n2.BrojStanovnika = 8122;

            //Console.WriteLine(n1.Opis());
            //Console.WriteLine(n2.Opis());

            // 2 prazna retka
            Console.WriteLine("\n");

            //1.	Kreirati instancu razreda Zupanija
            Zupanija z1 = new Zupanija("Međimurska županija");
            z1.DodajNaselje(n1);
            z1.DodajNaselje(n2);

            //2.	Kreirati nekoliko instanci razreda Naselje i dodati u listu naselja županije
            Naselje n3 = new Naselje("Šenkovec", 2708, VrstaNaselja.Selo);
            z1.DodajNaselje(n3);

            // u gornjim linijama kreirali smo objekte klase Naselje i spremili smo
            // reference u varijable n1, n2, n3 dok u donjim linijama kreiramo objekt i odmah ga
            // šaljemo u metodu koja ga stavlja u listu naselja županije
            // koristeći prvi način mi možemo kasnije ažurirati taj objekt direktno (vidi u donjoj liniji za n3)
            z1.DodajNaselje(new Naselje("Štrigova", 2766, VrstaNaselja.Selo));
            z1.DodajNaselje(new Naselje("Sv. Martin na Muri", 2958, VrstaNaselja.Selo));
            z1.DodajNaselje(new Naselje("Hodošan", 1311, VrstaNaselja.Selo));

            //3.	Ispisati podatke o županiji
            //Console.WriteLine(z1.Opis);
            //Console.WriteLine("Popis naselja:");

            // Naselju Šenkovec ažuriramo broj stanovnika
            // kod ispisa bude taj novi iznos (stari je bio 2708) jer lista sadrži referencu na pravi objekt u memoriji
            // a kojem mi ažuriramo vrijednost
            n3.BrojStanovnika = 11000;

            /*
             foreach (Naselje n in z1.Naselja)
             {
                 Console.WriteLine(n.Opis());
             }

             Console.WriteLine("Popis sela:");
             foreach (Naselje n in z1.GetNaseljaPoTipu(VrstaNaselja.Selo))
             {
                 Console.WriteLine(n.Opis());
             }
            */

            //4.	Ispisati broj trenutno kreiranih instanci razreda Naselje
            Console.WriteLine($"Kreirano naselja {Naselje.BrojKreiranihNaselja}");

            //6.	Kreirati nekoliko instanci razreda Zupanija
            Zupanija z2 = new Zupanija("Zagrebačka županija");
            //7.	Kreirati nekoliko instanci razreda Naselje i dodati u listu naselja županije
            Naselje n4 = new Naselje("Šenkovec", 2708, VrstaNaselja.Selo);
            z2.DodajNaselje(n4);
            z2.DodajNaselje(new Naselje("Bistra", 6632, VrstaNaselja.Selo));
            z2.DodajNaselje(new Naselje("Samobor", 37728, VrstaNaselja.Grad));

            Zupanija z3 = new Zupanija("Splitsko-dalmatinska županija");
            z3.DodajNaselje(new Naselje("Hvar", 4000, VrstaNaselja.Grad));
            z3.DodajNaselje(new Naselje("Trilj", 8228, VrstaNaselja.Grad));
            z3.DodajNaselje(new Naselje("Baška voda", 2400, VrstaNaselja.Selo));

            //ovaj objekt se neće dodati u listu jer već postoji takav u listi (isti naziv, vrsta i broj stanovnika)
            z3.DodajNaselje(new Naselje("Baška voda", 2400, VrstaNaselja.Selo));

            zupanije.Add(z1);
            zupanije.Add(z2);
            zupanije.Add(z3);

            //8.	Ispisati podatke o županiji
            foreach (Zupanija z in zupanije)
            {
                IspisiPodatkeZaZupaniju(z);
            }

            Console.WriteLine($"Kreirano naselja {Naselje.BrojKreiranihNaselja}");
            Console.WriteLine(new String('-', 40));

            //9.	Kreirati novu instancu razreda Naselje i usporediti s već ranije kreiranom
            // instancom istog razreda – ispisati dal je ista referenca i dal je isti sadržaj
            bool usporedba = n3.Equals(n4);
            bool usporedbaReferenci = object.ReferenceEquals(n3, n4);
            Console.WriteLine("Usporedba 2 naselja:");
            Console.WriteLine($"\t{n3.Opis()}");
            Console.WriteLine($"\t{n4.Opis()}");
            Console.WriteLine($" Po vrijednostima: {usporedba}, po referenci: {usporedbaReferenci}");

            n3.BrojStanovnika = 2708;
            usporedba = n3.Equals(n4);
            usporedbaReferenci = object.ReferenceEquals(n3, n4);
            Console.WriteLine("Nakon ažuriranja broja stanovnika");
            Console.WriteLine("Usporedba 2 naselja:");
            Console.WriteLine($"\t{n3.Opis()}");
            Console.WriteLine($"\t{n4.Opis()}");
            Console.WriteLine($" Po vrijednostima: {usporedba}, po referenci: {usporedbaReferenci}");

            Console.ReadKey();
        }

        //5.	Kreirati statičku metodu koja ispisuje podatke o županiji kao na slici niže
        static void IspisiPodatkeZaZupaniju(Zupanija z)
        {
            Console.WriteLine($"ŽUPANIJA: {z.Naziv}");
            Console.WriteLine("Statistika");
            Console.WriteLine(z.Opis);
            Console.WriteLine($"Gradova: \t{z.BrojGradova}");
            Console.WriteLine($"Sela: \t\t{z.BrojSela}");
            Console.WriteLine($"\nPopis svih naselja({z.BrojNaselja}):");
            foreach (Naselje n in z.Naselja)
            {
                Console.WriteLine($"\t{n.Opis()}");
            }

            Console.WriteLine($"\nPopis gradova ({z.BrojGradova}):");
            foreach (Naselje n in z.GetGradovi())
            {
                Console.WriteLine($"\t{n.Opis()}");
            }

            Console.WriteLine($"\nPopis sela ({z.BrojSela}):");
            foreach (Naselje n in z.GetNaseljaPoTipu(VrstaNaselja.Selo))
            {
                Console.WriteLine($"\t{n.Opis()}");
            }
            Console.WriteLine(new String('-', 40));
        }
    }
}
