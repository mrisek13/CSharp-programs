using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Vj6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kreiramo objekt vl1 razreda VlasnikKosarice i kroz konstruktor dodjeljujemo vrijednosti
            VlasnikKosarice vl1 = new VlasnikKosarice("321123", "Fabijan Horvat", "Mihovljanska 2, Čakovec");
            // pozivamo metodu kojom definiramo vrijednost varijable adresa
            vl1.SetAdresa("Poljska 54, Varaždin");
            // ispisujemo podatke o kupcu pozivanjem metode Opis
            Console.WriteLine(vl1.Opis());

            // Kreiramo objekt razreda StavkaKosarice i kroz konstruktor dodjeljujemo vrijednosti varijablama razreda
            // kod definiranja decimalnih vrijednosti u decimal tip varijable moramo koristiti sufix m, npr. 299.99m
            StavkaKosarice st1 = new StavkaKosarice("Mobitel Samsung A54", 2, 299.99m);
            // definiramo količinu stavke
            // kod definiranja decimalnih vrijednosti u float tip varijable moramo koristiti sufix f, npr. 2.5f
            st1.Kolicina = 2.5f;
            // ispisujemo podatke o stavci - .NET automatski poziva metodu ToString() nad objektom st1
            Console.WriteLine(st1);

            // Kreiramo objekt razreda Kosarica i kroz konstruktor mu šaljemo objekt s podacima o kupcu vl1
            Kosarica k1 = new Kosarica(vl1);
            // Pozivom metode DodajStavku u listu stavaka košarice dodajemo stavku st1
            k1.DodajStavku(st1);

            StavkaKosarice st2 = new StavkaKosarice("USB C kabel", 2, 9.99m);
            k1.DodajStavku(st2);

            // Dodajemo stavku u košaricu pozivanjem metode DodajStavku koja kreira objekt razreda
            // StavkaKosarice i dodaje u listu stavaka
            k1.DodajStavku("Baterija AA", 4, 0.49m);
            IspisKosarice(k1);

            // Mijenjamo adresu za dostavu
            k1.Kupac.SetAdresa("I.G. Kovačića 25, Varaždin");

            // ovu liniju ispod komentirati ako želimo kasniju modifikaciju stavaka - dodavanje/brisanje
            //k1.Plati();

            // nakon plaćanja ili storniranja, ažuriranja stavaka više nemaju utjecaja na košaricu
            k1.DodajStavku("Baterija AAA", 9, 0.49m);

            Console.WriteLine("\nIspis košarice nakon ažuriranja stavaka...\n");
            IspisKosarice(k1);

            // brišemo stavku objekta st1
            k1.BrisiStavku(st1);

            // brišemo stavku s indeksom 1
            k1.BrisiStavku(1);

            //k1.IsprazniKosaricu();

            Console.WriteLine("\nIspis košarice nakon ažuriranja stavaka...\n");
            IspisKosarice(k1);

            Console.ReadKey();
        }

        public static void IspisKosarice(Kosarica kos)
        {
            Console.WriteLine("#####################################################");
            Console.WriteLine($"Košarica ID: {kos.Id}");
            Console.WriteLine($"Kupac:       {kos.Kupac.Opis()}");
            Console.WriteLine("-----------------------------------------------------");
            //for petljom prolazimo kroz stavke košarice i svaka interacija ispisuje podatke o stavci
            //kad u ispisu pozivamo samo objekt, u ovom slučaju stavke[i] koja vraća objekt razreda StavkaKosarice
            //poziva se ToString() metoda tog objekta
            for (int i = 0; i < kos.Stavke.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {kos.Stavke[i]}");
            }
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine($"UKUPNO:      {kos.Vrijednost}");
            Console.WriteLine("#####################################################");
        }
    }
}
