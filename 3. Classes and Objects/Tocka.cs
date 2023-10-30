using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Vj3
{
    //1.	Ispravno definiran naziv razreda
    class Tocka
    {
        //2.	Podatak o apscisi (x) tipa float dostupan samo unutar razreda
        float x;
        //3.	Podatak o ordinati (y) tipa float dostupan samo unutar razreda
        float y;

        //4.	Metodu za postavljanje vrijednosti varijable x
        public void PostaviX(float x)
        {
            this.x = x;
        }

        //5.	Metodu za postavljanje vrijednosti varijable y
        public void PostaviY(float y)
        {
            this.y = y;
        }

        //6.	Metodu za dohvat vrijednosti varijable x
        public float VratiX()
        {
            return x;
        }

        //7.	Metodu za dohvat vrijednosti varijable y
        public float VratiY()
        {
            return y;
        }

        //8.	Metodu za postavljanje obje varijable x i y u jednom pozivu
        public void PostaviXY(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        //9.	Metodu za apsolutni pomak točke na x i y koja prima jedan parametar tipa Tocka
        public void PomakniNa(Tocka t)
        {
            //kao parametar dobivamo objekt tipa Tocka te preslikamo njegove vrijednosti u varijable x i y
            this.x = t.VratiX();
            this.y = t.VratiY();
        }

        //10.	Metodu za relativni pomak točke u x i y smjeru (s obzirom na trenutni položaj)
        public void PomakniZa(float dx, float dy)
        {
            x = x + dx;
            y += dy;
        }

        //11.	Privatnu metodu za izračun udaljenosti do točke definirane pomoću dvije float koordinate
        //formula je uvijek ista pa je pozivamo iz funkcija UdaljenostDo(Tocka t) i UdaljenostDo(float x, float y)
        //čime izbjegavamo pisati istu formulu na 2 mjesta
        private float Udaljenost(float x, float y)
        {
            //Math.Sqrt nam vraća rezultat u obliku double tipa podatka koji ima veću preciznost od
            //tipa float (tj. može imati više decimala) kojeg vraća naša funkcija pa je potrebno
            //pretvoriti double tip podatke u float na donji način: (float)Math... -> postupak koji zovemo casting
            return (float)Math.Sqrt(Math.Pow(this.x - x, 2) + Math.Pow(this.y - y, 2));
        }

        //13.	Metodu za izračun udaljenosti do točke koja se metodi predaje kao tip Tocka
        public float UdaljenostDo(Tocka t)
        {
            //pozivamo metodu Udaljenost kojoj prosljeđujemo vrijednosti varijabli x i y objekta t
            return Udaljenost(t.VratiX(), t.VratiY());
        }

        //12.	Metodu za izračun udaljenosti do točke čiji se parametri predaju kao dvije koordinate tipa float
        public float UdaljenostDo(float x, float y)
        {
            //pozivamo metodu Udaljenost kojoj prosljeđujemo vrijednosti varijabli x i y
            return Udaljenost(x, y);
        }

    }
}
