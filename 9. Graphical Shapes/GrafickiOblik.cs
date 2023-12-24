using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Vj10
{
    class GrafickiOblik
    {
        protected double x;
        protected double y;
        protected double sirina;
        protected double visina;

        //1.	Konstruktor sa 4 ulazna parametra (x, y, sirina, visina)
        public GrafickiOblik(double x, double y,
            double sirina, double visina)
        {
            this.x = x;
            this.y = y;
            this.visina = visina;
            this.sirina = sirina;
        }

        //2.	Konstruktor sa 2 ulazna parametra (x, y)
        public GrafickiOblik(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        //3.	Virtualnu metodu Nacrtaj()
        public virtual void Nacrtaj()
        {
            Console.WriteLine($"Crtam grafički oblik X: {x}, Y: {y}, Š: {sirina}, V: {visina}");
        }
    }
}
