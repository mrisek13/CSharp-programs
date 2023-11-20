using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Vj6
{
    class StavkaKosarice
    {
                // privatne varijable
        // za financijske stvari obično koristimo decimal tip
        string opis;
        float kolicina;
        decimal cijena;

        // 1.	Konstruktor sa 3 ulazna parametra (opis, količina, cijena)
        public StavkaKosarice(string opis, float kolicina, decimal cijena)
        {
            this.opis = opis;
            this.kolicina = kolicina;
            this.cijena = cijena;
        }

        //2.	Konstruktor sa 2 ulazna parametra (opis, cijena) – količina je 1
        public StavkaKosarice(string opis, decimal cijena)
        {
            this.opis = opis;
            this.kolicina = 1;
            this.cijena = cijena;
        }

        // 3.	Svojstvo Opis
        public string Opis
        {
            get
            {
                return opis;
            }
            set
            {
                opis = value;
            }
        }

        // 4.	Svojstvo Kolicina
        public float Kolicina
        {
            get { return kolicina; }
            set { kolicina = value; }
        }

        // 5.	Svojstvo Cijena
        public decimal Cijena
        {
            get { return cijena; }
            set { cijena = value; }
        }

        // 6.	Svojstvo Vrijednost
        public decimal Vrijednost
        {
            get
            {
                return Math.Round(cijena * (decimal)kolicina, 2);
            }
        }

        // 7.	Metodu za ispis podataka o objektu
        public override string ToString()
        {
            //{opis,-20} - definiramo da je za sadržaj predviđeno 20 znakova tj. simuliramo kolonu,
            //minus označava da će sadržaj biti poravnat ulijevo a ako je pozitivno onda desno
            //više na https://learn.microsoft.com/en-us/dotnet/api/system.string.format?view=netframework-4.7.2
            return $"{opis,-20}{kolicina,10}{cijena,10}{Vrijednost,10}";
        }
    }
}
