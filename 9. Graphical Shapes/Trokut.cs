using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Vj10
{
    //1.	Nasljeđuje bazni razred GrafickiOblik
    class Trokut : GrafickiOblik
    {
        //2.	Sadrži varijable za ostale koordinate vrhova x2, y2 i x3, y3
        double x2;
        double y2;
        double x3;
        double y3;

        //3.	Konstruktor sa 6 ulazna parametra (x, y, x2, y2, x3, y3)
        public Trokut(double x1, double y1, double x2, double y2, double x3, double y3)
            : base(x1, y1)  // pozivamo konstruktor baznog razreda s 2 parametra
        {
            this.x2 = x2;
            this.y2 = y2;
            this.x3 = x3;
            this.y3 = y3;
        }

        //4.	Nacrtaj()
        public override void Nacrtaj()
        {
            Console.WriteLine($"Crtam trokut T1({x},{y}), T2({x2},{y2}), T3({x3},{y3})");
        }
    }
}

