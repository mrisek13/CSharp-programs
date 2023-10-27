using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba_04
{
    class Valjak
    {
        //1.	Podatak polumjeru baze (float)
        float polumjerBaze;
        //2.	Podatak o visini(float)
        float visina;

        public Valjak(float radius, float visina)
        {
            this.polumjerBaze = radius;
            this.visina = visina;
        }

        public Valjak()
        {
        }

        //3.	Metodu za postavljanje polumjera baze
        public void SetPolumjerBaze(float polumjerBaze)
        {
            this.polumjerBaze = polumjerBaze;
        }

        //4.	Metodu za dohvat polumjera baze
        public float GetPolumjerBaze()
        {
            return polumjerBaze;
        }

        //5.	Metodu za postavljanje visine
        public void SetVisina(float visina)
        {
            this.visina = visina;
        }

        //6.	Metodu za dohvat visine
        public float GetVisina()
        {
            return visina;
        }

        //7.	Svojstvo PolumjerBaze
        // zamjena za metode GetPolumjerBaze() i SetPolumjerBaze()
        // tj. te metode i ovo svojstvo imaju istu svrhu - vratiti vrijednost
        // i podesiti vrijednost varijable polumjerBaze
        public float PolumjerBaze
        {
            get //poziva se kad dohvaćamo vrijednost svojstva
            {
                return polumjerBaze;
            }
            set //poziva se kad dodjeljujemo vrijednost svojstvu
            {
                polumjerBaze = value;
            }
        }

        //8.	Svojstvo Visina
        public float Visina
        {
            get
            {
                return visina;
            }
            set
            {
                visina = value;
            }
        }

        //9.	Metodu za izračun površine baze
        private double IzracunajPovrsinuBaze()
        {
            // ovdje koristimo pomoćnu varijablu povrsina, mogli smo riješiti kao i
            // metodu IzracunajPovrsinuPlasta gdje smo koristili return pa matematičku formulu
            double povrsina = 0;
            povrsina = Math.Pow(polumjerBaze, 2) * Math.PI;
            return povrsina;
        }

        //10.	Metodu za izračun površine plašta
        private double IzracunajPovrsinuPlasta()
        {
            return 2 * polumjerBaze * Math.PI * visina;
        }

        //11.	Svojstvo za izračun oplošja valjka
        public double Oplosje
        {
            get
            {
                //Math.Round zaokružuje neki broj (1. argument) na n decimala (2. argument)
                return Math.Round(2 * IzracunajPovrsinuBaze() + IzracunajPovrsinuPlasta(), 2);
            }
        }

        //12.	Svojstvo za izračun volumena
        public double Volumen
        {
            get
            {
                return Math.Round(Math.Pow(polumjerBaze, 2) * Math.PI * visina, 2);
            }
        }

        //13.	Metodu za ispis objekta
        // ToString() metoda je svojstvena za sve tipove podataka u .NET-u
        // potječe iz object tipa podatka koji je root za sve tipove podataka (više o tome kasnije)
        // pomoću override je nadvladavamo da ispisuje ono što mi želimo
        // jer bi inače ispisala Vjezba_04.Valjak - tj. namespace i naziv razreda
        public override string ToString()
        {
            return $"Polumjer: {polumjerBaze} Visina: {visina} Oplošje: {Oplosje} Volumen: {Volumen}";
        }


    }
}
