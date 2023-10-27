using System;

namespace Vjezba_04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kreiramo objekt v1 klase Valjak
            Valjak v1 = new Valjak();
            Console.WriteLine($"v1 Polumjer baze: {v1.GetPolumjerBaze()} visina: {v1.GetVisina()}");

            Valjak v2 = new Valjak();
            //Pozivamo metodu za postavljanje vrijednosti polumjera baze
            v2.SetPolumjerBaze(10);
            v2.SetVisina(5);
            Console.WriteLine($"v2 Polumjer baze: {v2.GetPolumjerBaze()} visina: {v2.GetVisina()}");

            Valjak v3 = new Valjak();
            //Vrijednost postavljamo pomoću svojstva (propertya)
            v3.PolumjerBaze = 13;
            v3.Visina = 3;
            Console.WriteLine($"v3 Polumjer baze: {v3.PolumjerBaze} visina: {v3.Visina} " +
                $"oplosje: {v3.Oplosje} volumen: {v3.Volumen}");

            Console.WriteLine("v3: " + v3.ToString());

            Valjak v4 = new Valjak();
            v4.PolumjerBaze = 1;
            v4.Visina = 44;
            Console.WriteLine("v4: " + v4.ToString());

            Kugla k1 = new Kugla();
            k1.Polumjer = 2;
            Console.WriteLine("k1: " + k1.ToString());

            Kugla k2 = new Kugla();
            k2.Polumjer = 10;
            //.ToString() nije potrebno pozivati jer se poziva automatski kad neku varijablu
            // odnosno objekt koristimo u ispisu
            Console.WriteLine("k2: " + k2);

            Kugla k3 = new Kugla();
            k3.Polumjer = 6;
            Console.WriteLine("k3: " + k3);

            // Dodatni zadatak
            unosValjaka();
            Console.ReadKey();
        }

        /// <summary>
        ///     Dodatni zadatak:
        ///     Kreiranje N objekata razreda Valjak (korisnik odabire koliko objekata želi kreirati i unosi podatke za polumjer
        ///     baze i visinu svakog objekta) nakon čega petljom proći kroz polje kreiranih objekta i ispisati podatke koristeći
        ///     metodu ToString();
        /// </summary>
        private static void unosValjaka()
        {

            Console.Write("Unesite broj koliko ukupno objekata razreda \"Valjak\" želite kreirati: ");
            int broj = Convert.ToInt32(Console.ReadLine());
            Valjak[] polje = new Valjak[broj];

            float radius = 0;
            float visina = 0;

            for (int i = 0; i < broj; i++)
            {
                Console.WriteLine("Unesi polumjer baze za valjak br." + (i + 1));
                radius = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("Unesi visinu valjka br." + (i + 1));
                visina = Convert.ToSingle(Console.ReadLine());

                polje[i] = new Valjak(radius, visina);
            }

            for (int i = 0; i < broj; i++)
            {
                Console.WriteLine("Opis valjka br." + (i + 1));
                Console.WriteLine(polje[i].ToString());
            }
        }
    }
}
