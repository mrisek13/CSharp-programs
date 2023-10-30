using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Vj3
{
    //1.	Ispravno definiran naziv razreda
    class Pravokutnik
    {
        //2.    Podatak o dužini stranice A tipa float dostupan samo unutar razreda
        float stranicaA;

        //3.	Podatak o dužini stranice B tipa float dostupan samo unutar razreda
        float stranicaB;

        //4.	Metodu za dohvat vrijednosti varijable stranicaA
        public float VratiStranicuA()
        {
            return stranicaA;
        }
        //5.	Metodu za postavljanje vrijednosti varijable stranicaA 
        public void PostaviStranicuA(float strA)
        {
            // ako se definira negativna količina izbaciti grešku
            if (strA < 0)
                throw new Exception("Vrijednost mora biti veća od 0");

            stranicaA = strA;
        }

        //6.	Metodu za dohvat vrijednosti varijable stranicaB
        public float VratiStranicuB()
        {
            return stranicaB;
        }

        //6.	7.	Metodu za postavljanje vrijednosti varijable stranicaB 
        public void PostaviStranicuB(float strB)
        {
            // ako se definira negativna količina izbaciti grešku
            if (strB < 0)
                throw new Exception("Vrijednost mora biti veća od 0");

            stranicaB = strB;
        }

        //8.	Metodu koje vraća površinu pravokutnika
        public float VratiPovrsinu()
        {
            return stranicaA * stranicaB;
        }

        //9.	Metodu koje vraća opseg pravokutnika
        public float VratiOpseg()
        {
            return 2 * stranicaA + 2 * stranicaB;
        }

        //10.	Metodu za izračun dijagonale
        public double VratiDijagonalu()
        {
            return Math.Sqrt(Math.Pow(stranicaA, 2) + Math.Pow(stranicaB, 2));
        }

        //11.	Metodu za provjeru ako je pravokutnik kvadrat
        public bool JeKvadrat()
        {
            //PRVI NAČIN
            /*if (stranicaA == stranicaB)
                return true;
            else
                return false;*/

            //ILI DRUGI NAČIN
            //return stranicaA == stranicaB ? true : false;

            //ILI TREĆI NAČIN
            return stranicaA == stranicaB;
        }

    }
}
