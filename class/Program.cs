using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Vj3
{
    class Program
    {
        static void Main(string[] args)
        {
            //kreiramo instancu razreda Tocka
            Tocka t1 = new Tocka();

            //pozivamo metode pomoću kojih postavljamo vrijednosti internih varijabli x i y koje su privatne
            //pa nisu dostupne direktno izvana
            t1.PostaviX(5);
            t1.PostaviY(10);

            //kreiramo instancu razreda Tocka
            Tocka t2 = new Tocka();
            t2.PostaviX(2);
            t2.PostaviY(9);

            //kreiramo instancu razreda Tocka
            Tocka t3 = new Tocka();

            //ispisujemo koordinate x, y svakog kreiranog objekta
            Console.WriteLine($"T1= {t1.VratiX()},{t1.VratiY()}");
            Console.WriteLine($"T2= {t2.VratiX()},{t2.VratiY()}");
            Console.WriteLine($"T3= {t3.VratiX()},{t3.VratiY()}");

            //postavljamo x i y koordinate točke t3 pomoću metode PostaviXY
            t3.PostaviXY(12, 8);
            Console.WriteLine($"T3= {t3.VratiX()},{t3.VratiY()}");

            //koordinate točke t3 selimo na koordinate ročke t1
            t3.PomakniNa(t1);
            Console.WriteLine($"T3= {t3.VratiX()},{t3.VratiY()}");

            //točku t3 selimo za određenu vrijednost po x i y osi
            t3.PomakniZa(4, 33);
            Console.WriteLine($"T3= {t3.VratiX()},{t3.VratiY()}");

            //izračunavamo udaljenost točke t3 do točke t1
            float udaljenost1 = t3.UdaljenostDo(t1);
            Console.WriteLine($"Udaljednost T3 do T1: {udaljenost1}");

            //izračunavamo udaljenost točke t3 do točke 1,1
            float udaljenost2 = t3.UdaljenostDo(1, 1);
            Console.WriteLine($"Udaljednost T3 do 1,1: {udaljenost2}");

            //Zadatak 2: PRAVOKUTNIK
            //   \n je prazna linija
            Console.WriteLine("\n\nPravokutnik \n");

            Pravokutnik p1 = new Pravokutnik();
            p1.PostaviStranicuA(20);
            p1.PostaviStranicuB(10);

            Console.WriteLine($"p1 - stranica a: {p1.VratiStranicuA()}, stranica b: {p1.VratiStranicuB()}");

            Console.WriteLine("Površina p1: " + p1.VratiPovrsinu());
            Console.WriteLine("Opseg p1: " + p1.VratiOpseg());
            Console.WriteLine("Dijagonala p1: " + p1.VratiDijagonalu());

            if (p1.JeKvadrat())
            {
                Console.WriteLine("p1 je kvadrat");
            }
            else
            {
                Console.WriteLine("p1 nije kvadrat");
            }

            //Drugi način ispisa ako je pravokutnik kvadrat
            //uvjetni izraz ? izraz1 (vraća se ako je uvjetni izraz true) : izraz2 (vraća se ako je uvjetni izraz false);
            Console.WriteLine("p1 je kvadrat: " + (p1.JeKvadrat() ? "DA" : "NE"));

            Console.WriteLine();

            Pravokutnik p2 = new Pravokutnik();
            p2.PostaviStranicuA(20);
            p2.PostaviStranicuB(20);
            Console.WriteLine($"p2 - stranica a: {p2.VratiStranicuA()}, stranica b: {p2.VratiStranicuB()}");

            Console.WriteLine("Površina p2: " + p2.VratiPovrsinu());
            Console.WriteLine("Opseg p2: " + p2.VratiOpseg());
            Console.WriteLine("Dijagonala p2: " + p2.VratiDijagonalu());

            Console.WriteLine("p2 je kvadrat: " + (p2.JeKvadrat() ? "DA" : "NE"));

            Console.ReadKey();
        }
    }
}
