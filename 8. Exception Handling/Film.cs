using System;

namespace OOP_Vj9
{
    class Film
    {
        string oznaka;
        string naziv;
        int kolicina;
        int posudjeno;

        //1.	Konstruktor (oznaka, naziv, količina)
        public Film(string oznaka, string naziv, int kolicina)
        {
            this.oznaka = oznaka;
            this.naziv = naziv;
            this.kolicina = kolicina;
        }

        //2.	Svojstvo Oznaka
        public string Oznaka
        {
            get { return oznaka; }
            set { oznaka = value; }
        }

        //3.	Svojstvo Naziv
        public string Naziv
        {
            get { return naziv; }
            set { naziv = value; }
        }

        //4.	Svojstvo Kolicina
        public int Kolicina
        {
            get { return kolicina; }
            set { kolicina = value; }
        }

        //5.	Svojstvo Posudjeno
        public int Posudjeno
        {
            get { return posudjeno; }
            set { posudjeno = value; }
        }

        //6.	Read-only svojstvo Slobodno – izračunava se: kolicina - broj posuđenih
        public int Slobodno
        {
            get { return kolicina - posudjeno; }
        }

        //7.	Metoda Posudba()
        //  	Potrebno je voditi računa o tome da li ima slobodnih primjeraka filma prije posuđivanja
        public void Posudba()
        {
            // ako ima slobodnih primjeraka
            if (Slobodno > 0)
                // povećava za 1 broj posuđenih primjeraka
                posudjeno++;
            else
                // izbaciti iznimku sa porukom ako nema više slobodnih primjeraka
                throw new Exception($"Nema slobodnog primjerka filma {oznaka}");
        }

        //8.	Metoda Vrati()
        //  	Potrebno je voditi računa o tome da li ima posuđenih primjeraka prije vraćanja
        public void Vrati()
        {
            // ako ima posuđenih primjeraka
            if (posudjeno > 0)
                // smanjuje za 1 broj posuđenih primjeraka
                posudjeno--;
            else
                // izbaciti iznimku sa porukom ako su svi primjerci vraćeni
                throw new Exception("Svi primjerci su na broju");
        }

        //9.	Metoda Nabavka(int primjeraka) – povećava količinu primjeraka
        public void Nabavka(int primjeraka)
        {
            kolicina += primjeraka;
        }
    }
}
