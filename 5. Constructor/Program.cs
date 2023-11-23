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

            Console.WriteLine("Dodatni zadaci:");

            /*
             * Dodatni zadaci:
                Kreirati barem 2, 3 košarice, kupca, više stavaka i isprobati dodavanje/brisanje stavaka, pozivanje
                metoda/svojstva za postavljanje vrijednosti kreiranih objekata te ispis košarica
             */

            VlasnikKosarice vlasnik1 = new VlasnikKosarice("456789", "Ivo Ivić", "Trg kralja Tomislava 10, OS");
            vlasnik1.SetAdresa("Trg bana Josipa Jelačića 75, Đakovo");
            vlasnik1.SetNaziv("Josip Josipović");

            Kosarica kos1 = new Kosarica(vlasnik1);
            kos1.DodajStavku("Mobitel Alcatel", 3, 399.99m);
            kos1.DodajStavku("Mobitel Xiaomi", 2, 299.99m);
            kos1.DodajStavku("Mobitel Samsung A50", 3, 499.99m);

            StavkaKosarice stavka1 = new StavkaKosarice("Mobitel iPhone 12 Pro Max", 2, 1499.99m);
            kos1.DodajStavku(stavka1);

            stavka1.Cijena = 1299.99m;
            stavka1.Kolicina = 3;
            stavka1.Opis = "Mobitel iPhone 12";

            kos1.BrisiStavku(0);
            kos1.BrisiStavku(stavka1);

            VlasnikKosarice vlasnik2 = new VlasnikKosarice("123456", "Maja Risek", "Zagrebačka 5, VŽ");
            Kosarica kos2 = new Kosarica(vlasnik2);

            kos2.DodajStavku("Laptop Dell D150", 2, 599.99m);
            kos2.DodajStavku("Laptop ACER A200", 3, 699.99m);
            kos2.DodajStavku("Laptop HP H340", 5, 999.99m);
            kos2.DodajStavku("Laptop Toshiba T5", 1, 6399.99m);
            kos2.DodajStavku("Laptop ACER A500", 3, 799.99m);
            kos2.DodajStavku("Laptop HP H680", 5, 899.99m);

            vlasnik2.SetNaziv("Ivan Horvat");
            vlasnik2.SetAdresa("Zagrebačka 60, Varaždin");

            StavkaKosarice stavka2 = new StavkaKosarice("Mobitel Motorola Edge 40", 2, 499.99m);
            kos2.DodajStavku(stavka2);

            stavka1.Cijena = 999.99m;
            stavka1.Kolicina = 6;
            stavka1.Opis = "Laptop Lenovo";

            kos2.BrisiStavku(0);
            kos2.BrisiStavku(stavka1);

            VlasnikKosarice vlasnik3 = new VlasnikKosarice("789456", "Marko Marić", "Kantrida 25, RI");
            vlasnik3.SetAdresa("Istarska 15, Rijeka");
            vlasnik3.SetNaziv("Fran Franjić");
            Kosarica kos3 = new Kosarica(vlasnik3);

            kos3.DodajStavku("Mobitel Alcatel A20", 3, 199.99m);
            kos3.DodajStavku("Mobitel Xiaomi X45", 2, 299.99m);
            kos3.DodajStavku("Mobitel Samsung A50", 3, 399.99m);
            kos3.DodajStavku("Mobitel Alcatel A80", 3, 399.99m);
            kos3.DodajStavku("Mobitel Xiaomi X50", 2, 599.99m);
            kos3.DodajStavku("Mobitel Samsung A30", 3, 499.99m);

            StavkaKosarice stavka3 = new StavkaKosarice("Tablet Samsung", 3, 399.99m);
            kos3.DodajStavku(stavka3);

            stavka3.Cijena = 499.99m;
            stavka3.Kolicina = 5;
            stavka3.Opis = "Tablet Samsung";

            kos3.BrisiStavku(0);
            kos3.BrisiStavku(stavka1);

            Console.WriteLine("\nIspis košarice nakon ažuriranja stavaka...\n");
            IspisKosarice(kos1);
            IspisKosarice(kos2);
            IspisKosarice(kos3);

            Console.ReadLine();
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
