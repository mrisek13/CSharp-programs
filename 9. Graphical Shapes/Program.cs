using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Vj10
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.	Dodati listu za spremanje objekata razreda GrafickiOblik
            // U listu možemo spremiti instance baznog razreda GrafickiOblik i instance svih izvedenih razreda (Cetverokut, Trokut, Kruznica)
            // Ukoliko bi definirali da je List<Cetverokut> tada bi mogli spremiti samo instance razreda Cetverokut
            List<GrafickiOblik> grafickiOblici = new List<GrafickiOblik>();

            //Kreiramo objekt razreda GrafickiOblik
            GrafickiOblik g1 = new GrafickiOblik(1, 1, 15, 20);
            g1.Nacrtaj();
            //Dodajemo objekt u listu
            grafickiOblici.Add(g1);

            //Kreiramo objekt razreda Cetverokut
            Cetverokut c1 = new Cetverokut(20, 30, 10, 5);
            c1.Nacrtaj();
            c1.VratiPovrsinu();
            grafickiOblici.Add(c1);

            GrafickiOblik c2 = new Cetverokut(10, 10, 20, 30);
            c2.Nacrtaj();
            //c2.VratiPovrsinu(); // varijabla je tipa GrafickiOblik, tj. bazni razred prije pokretanja programa pa ne možemo pozivati metodu VratiPovrsinu()
            grafickiOblici.Add(c2);

            Trokut t1 = new Trokut(2, 3, 4, 5, 6, 7);
            grafickiOblici.Add(t1);

            Kruznica k1 = new Kruznica(10, 10, 22);
            grafickiOblici.Add(k1);

            foreach (GrafickiOblik go in grafickiOblici)
            {
                go.Nacrtaj();
            }

            Kruznica k2 = new Kruznica(14, 8, 4);
            grafickiOblici.Add(k1);

            IspisiOblike(grafickiOblici);

            Console.ReadKey();
        }

        //3.	Definirati metodu koja kao argument prima listu GrafickiOblik i pokreće metodu Nacrtaj() svakog elementa liste
        // U gornjem kodu smo uočili da se programski kod za ispis liste grafičkih oblika ponavlja na više mjesta: foreach (var ob...
        // pa smo taj problem riješili na način da smo taj kod izdvojili u zasebnu metodu čime smo dobili jednostavniji,
        // čišći kod koji se i lakše održava
        private static void IspisiOblike(List<GrafickiOblik> oblici)
        {
            Console.WriteLine("----- CRTAM ----");
            foreach (GrafickiOblik go in oblici)
            {
                go.Nacrtaj();
            }
            Console.WriteLine("----------------");
        }
    }
}
