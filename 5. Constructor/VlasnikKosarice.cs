using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Vj6
{
    class VlasnikKosarice
    {
                // privatne varijable
        string id;
        string naziv;
        string adresa;

        // 1.	Konstruktor sa 3 ulazna parametra (id, naziv, adresa)
        public VlasnikKosarice(string id, string naziv, string adresa)
        {
            this.id = id;
            this.naziv = naziv;
            this.adresa = adresa;
        }

        // 2.	Metoda za dohvat id-a
        public string GetId()
        {
            return id;
        }

        // 3.	Metoda za dohvat naziva
        public string GetNaziv()
        {
            return naziv;
        }

        // 4.	Metoda za postavljanje naziva
        public void SetNaziv(string naziv)
        {
            this.naziv = naziv;
        }

        // 5.	Metoda za dohvat adrese
        public string GetAdresa()
        {
            return adresa;
        }

        // 6.	Metoda za postavljanje adrese
        public void SetAdresa(string adresa)
        {
            this.adresa = adresa;
        }

        // 7.	Metoda za ispis podataka o objektu
        public string Opis()
        {
            return id + " - " + naziv + " - " + adresa;
        }
    }
}
