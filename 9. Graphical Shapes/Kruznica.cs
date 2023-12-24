using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Vj10
{
    //3.	Razred Kruznica
    class Kruznica : GrafickiOblik
    {
        //2.	Sadrži varijablu za polumjer
        double polumjer;

        //3.	Konstruktor sa 3 ulazna parametra (x, y, polumjer)
        public Kruznica(double x, double y, double polumjer)
            : base(x, y) //pozivamo konstruktor baznog razreda s 2 parametra
        {
            this.polumjer = polumjer;
        }

        //4.	Nacrtaj() - ukoliko bi izostavili ovu metodu i nad objektom razreda Kruznica pokretali metodu Nacrtaj
        // izvršavala bi se metoda iz baznog razreda
        public override void Nacrtaj()
        {
            Console.WriteLine($"Crtam kružnicu na X:{x}, Y:{y} polumjera: {polumjer}");
        }
    }
}

