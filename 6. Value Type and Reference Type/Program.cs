using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Vj7
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
                Naselje n1 = new Naselje("Čakovec", 15147, VrstaNaselja.Grad);

                Naselje n2 = new Naselje("Prelog", 7781, VrstaNaselja.Grad);
                n2.BrojStanovnika = 8122;

                Console.WriteLine(n1.Opis());
                Console.WriteLine(n2.Opis());

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
                Console.WriteLine(z1.Opis);
                Console.WriteLine("Popis naselja:");

                // Naselju Šenkovec ažuriramo broj stanovnika
                // kod ispisa bude taj novi iznos (stari je bio 2708) jer lista sadrži referencu na pravi objekt u memoriji
                // a kojem mi ažuriramo vrijednost
                n3.BrojStanovnika = 11000;

                foreach (Naselje n in z1.Naselja)
                {
                    Console.WriteLine(n.Opis());
                }

                Console.WriteLine("Popis sela:");
                foreach (Naselje n in z1.GetNaseljaPoTipu(VrstaNaselja.Selo))
                {
                    Console.WriteLine(n.Opis());
                }

                Console.ReadKey();
            }
        }

    }
