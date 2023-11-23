using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Vj7
{
    class Zupanija
    {
        string naziv;

        // List je tip podatka koji omogućava spremanje kolekcije - ista namjena kao i array
        // unutar <> moramo navesti koji tip podatka možemo spremati u takvu listu
        // više: https://www.c-sharpcorner.com/article/c-sharp-list/
        //       https://www.tutorialsteacher.com/csharp/csharp-list
        List<Naselje> naselja = new List<Naselje>();

        //1.	Konstruktor sa 1 ulaznim parametrom (naziv)
        public Zupanija(string naziv)
        {
            this.naziv = naziv;
        }

        //2.	Svojstvo Naziv
        public string Naziv
        {
            get { return naziv; }
            set { this.naziv = value; }
        }

        //3.	DodajNaselje(Naselje) – dodavanje naselja u listu naselja
        public void DodajNaselje(Naselje naselje)
        {
            naselja.Add(naselje);
        }

        //4.	Svojstvo Naselja – vraća listu naselja
        public List<Naselje> Naselja
        {
            get { return naselja; }
        }

        //5.	Metoda koja vraća gradove iz liste naselja
        public List<Naselje> GetGradovi()
        {
            // Kreiramo privremenu listu naselja
            List<Naselje> gradovi = new List<Naselje>();

            // Prolazimo kroz naselja županije
            foreach (Naselje n in naselja)
            {
                // provjeravamo ako trenutačni objekt u iteraciji ima vrstu naselja Grad
                if (n.GetVrstaNaselja() == VrstaNaselja.Grad)
                {
                    // dodajemo naselje u privremenu listu
                    gradovi.Add(n);
                }
            }

            // vraćamo listu filtriranih naselja, tj. naselja koja su grad
            return gradovi;
        }

        //6.	Metoda koja vraća sela iz liste naselja
        public List<Naselje> GetSela()
        {
            List<Naselje> sela = new List<Naselje>();
            foreach (Naselje n in naselja)
            {
                if (n.GetVrstaNaselja() == VrstaNaselja.Selo)
                {
                    sela.Add(n);
                }
            }
            return sela;
        }

        //7.	Metoda koja vraća naselja ovisno o parametru tipa VrstaNaselja
        public List<Naselje> GetNaseljaPoTipu(VrstaNaselja vrstaNaselja)
        {
            List<Naselje> tmpNaselja = new List<Naselje>();
            foreach (Naselje n in naselja)
            {
                if (n.GetVrstaNaselja() == vrstaNaselja)
                {
                    tmpNaselja.Add(n);
                }
            }
            return tmpNaselja;
        }


        //8.	Svojstvo BrojNaselja
        public int BrojNaselja
        {
            get { return naselja.Count; }
        }

        //9.	Svojstvo BrojGradova
        public int BrojGradova
        {
            get
            {
                int brGradova = 0;
                foreach (Naselje n in naselja)
                {
                    if (n.GetVrstaNaselja() == VrstaNaselja.Grad)
                        brGradova++;
                }
                return brGradova;
            }
        }

        //10.	Svojstvo BrojSela
        public int BrojSela
        {
            get
            {
                return GetNaseljaPoTipu(VrstaNaselja.Selo).Count;
                //ili return VratiSela().Count;
            }
        }

        //11.	Svojstvo BrojStanovnika
        public int BrojStanovnika
        {
            get
            {
                int brojStanovnika = 0;
                foreach (Naselje n in naselja)
                {
                    brojStanovnika += n.BrojStanovnika;
                }
                return brojStanovnika;
            }
        }

        //12.	Svojstvo Opis – vraća naziv, broj naselja, broj stanovnika
        public string Opis
        {
            get
            {
                return $"{naziv} ima {BrojNaselja} naselja sa {BrojStanovnika} stanovnika";
            }
        }

    }
}
