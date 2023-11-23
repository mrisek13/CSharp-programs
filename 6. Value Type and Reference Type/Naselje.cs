using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Vj7
{
    class Naselje
    {
        string naziv;
        int stanovnika;
        VrstaNaselja vrstaNaselja;

        //1.	Konstruktor sa 3 ulazna parametra (naziv, broj stanovnika, vrsta naselja)
        public Naselje(string naziv, int stanovnika, VrstaNaselja vrstaNaselja)
        {
            this.naziv = naziv;
            this.stanovnika = stanovnika;
            this.vrstaNaselja = vrstaNaselja;
        }

        //2.	Metoda koja vraća vrijednost varijable naziv
        public string GetNaziv()
        {
            return naziv;
        }

        //3.	Metoda koja vraća vrijednost varijable vrsta naselja
        public VrstaNaselja GetVrstaNaselja()
        {
            return vrstaNaselja;
        }

        //4.	Svojstvo BrojStanovnika kojim se vraća/postavlja broj stanovnika
        public int BrojStanovnika
        {
            get { return stanovnika; }
            set { stanovnika = value; }
        }

        //5.	Metoda Opis – Vraća naziv, vrstu naselja i broj stanovnika
        public string Opis()
        {
            return $"{naziv} je {vrstaNaselja} ima {stanovnika} stanovnika";
        }

        //6.	Metoda Jednako – Uspoređivanje 2 naselja, uspoređuje vrijednosti varijabli
        // trenutačne instance s instancom dobivenom kao parametar
        // 2  instance su jednake ako su im jednaki nazivi, broj stanovnika i vrsta naselja
        public bool Jednako(Naselje nas)
        {
            //prvi način - možemo uspoređivati preko metoda/svojstva druge instance
            /*return naziv == nas.GetNaziv()
                && stanovnika == nas.BrojStanovnika
                && vrstaNaselja == nas.GetVrstaNaselja();*/

            // drugi način - usporedba preko privatnih varijabli
            // iako su varijable privatne mi im možemo pristupiti jer smo u istoj klasi (Naselje)
            // radi čitljivosti koristimo još this. da znamo da uspoređujemo s vrijednostima
            // varijabli trenutačne instance
            return this.naziv == nas.naziv
                && this.stanovnika == nas.stanovnika
                && this.vrstaNaselja == nas.vrstaNaselja;
        }

    }
}
