using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Vj10
{
    class Cetverokut : GrafickiOblik
    {
        //2.	Konstruktor sa 4 ulazna parametra (x, y, sirina, visina)
        public Cetverokut(double x, double y, double sirina, double visina)
            : base(x, y, sirina, visina) //pozivamo konstruktor baznog razreda
        {

        }

        //3.	Nacrtaj() – unutar nje pozvati i istu metodu baznog razreda
        // Koristimo ključnu riječ override kako bi "nadjačali" metodu Nacrtaj iz baznog razreda
        public override void Nacrtaj()
        {
            //base.Nacrtaj(); //Zovemo metodu Nacrtaj iz baznog razreda

            Console.WriteLine($"Crtam četverokut na X:{x}, Y:{y}" +
                $" Širine: {sirina}, Visine: {visina}");
        }

        // ova je metoda specifična za razred Cetverokut
        public void VratiPovrsinu()
        {
            Console.WriteLine($"Površina je: { visina * sirina}");
        }
    }
}
