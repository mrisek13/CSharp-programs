using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.	Ispišite pozdravnu poruku
            //Za ispisivanje i učitavanje sa konzole korisimo razred Console i metodu WriteLine
            Console.WriteLine("Pozdrav iz Čakovca!");

            //2.    Ispišite trenutačni datum i vrijeme
            //DateTime.Now nam vraća trenutačni datum i vrijeme koje se ispiše u obliku ovisno
            //o regionalnim postavkama operacijskog sustava: dan.mjesec.godina sat:minute:sekunde
            Console.WriteLine(DateTime.Now);

            //3.	Kreirajte 2 cjelobrojne varijable i ispišite njihovu sumu
            int x; //alokacija varijable x 
            x = 10; //inicijalizacija varijable x - definiranje njene vrijednosti
            int y = 9; //alokacija i inicijalizacija varijable y
            int z = x + y;
            Console.WriteLine("z = " + z);

            Console.WriteLine("-------------");

            //4.	Tražite od korisnika da unese 2 cijela broja nakon čega izračunajte i prikažite njihovu sumu
            int a, b, suma;
            //Console.WriteLine ispisuje sadržaj nakon čega kursor prebacuje u novi redak
            Console.WriteLine("Suma 2 broja");

            //Console.Write ispisuje sadržaj nakon čega kursor zadržava u trenutačnom retku
            Console.Write("a = ");
            //Čitamo unos, tj. ono što korisnik unese kroz konzolu i spremamo u varijablu s1
            string s1 = Console.ReadLine();
            //Unos kroz konzolu je string tipa, tj. tekstualni pa pomoću Convert.ToInt32 metode taj
            //tekst pretvaramo u cijeli broj, za decimalne brojeve koristili bi npr. Convert.ToDouble
            a = Convert.ToInt32(s1);

            Console.Write("b = ");  
            //U jednoj liniji očitavamo korisnikov unos kroz konzolu i to pretvaramo u cijeli broj
            b = Convert.ToInt32(Console.ReadLine());
            suma = a + b;
            Console.WriteLine("Suma = " + suma);

            Console.WriteLine("-------------");

            //5.	Tražite od korisnika da unese neki broj n
            Console.Write("Broj studenata = ");
            int brojStudenata = Convert.ToInt32(Console.ReadLine());
            //dinamički kreiramo string polje veličine koju je korisnik unio kroz konzolu
            string[] studenti = new string[brojStudenata];

            //i pomoću for petlje tražimo n puta unosa imena studenata
            //možemo koristiti i < studenti.Length ili i < brojStudenata
            for (int i=0; i < studenti.Length; i++)
            {
                //ispisujemo Student 1, 2, 3 na način da trenutačni index iteracije i uvećamo za 1
                //jer počinjemo od 0; i + 1 mora biti u zagradi tako da prvo uvećamo i a tek onda ispišemo
                //inače bi dobili 01 11 21 31...
                Console.Write("Student " + (i + 1) + ": ");
                string s = Console.ReadLine();
                //u polje na poziciju s indexom i spremamo unešenu vrijednost
                studenti[i] = s;
            }

            //ispisujemo vrijednosti u polju studenti
            for (int i = 0; i < studenti.Length; i++)
            {
                Console.WriteLine((i + 1) + ". student: " + studenti[i]);
            }

            Console.WriteLine("-------------");

            //6.	Tražite od korisnika unos ocjene 
            Console.Write("Unesite ocjenu = ");
            int ocjena = Convert.ToInt32(Console.ReadLine());

            //6. a)	if-else
            if (ocjena == 1)
            {
                Console.WriteLine("Nedovoljan");
            }
            else if (ocjena == 2)
            {
                Console.WriteLine("Dovoljan");
            }
            else if (ocjena == 3)
            {
                Console.WriteLine("Dobar");
            }
            else if (ocjena == 4)
            {
                Console.WriteLine("Vrlo dobar");
            }
            else if (ocjena == 5)
            {
                Console.WriteLine("Odličan");
            }
            else
            {
                Console.WriteLine("Krivi unos");
            }

            //6. b)	switch case
            //case 1 je zapravo if (ocjena == 1)
            //nakon svakog casea ide break; kako bi se prekinulo daljnje izvršavanje grananja
            //ako izostavimo break; u case 1 tada bi se nakon izvršavanja izvršio i case 2
            switch (ocjena)
            {
                case 1:
                    Console.WriteLine("Nedovoljan");
                    break;
                case 2:
                    Console.WriteLine("Dovoljan");
                    break;
                case 3:
                    Console.WriteLine("Dobar");
                    break;
                case 4:
                    Console.WriteLine("Vrlo dobar");
                    break;
                case 5:
                    Console.WriteLine("Odličan");
                    break;
                default:
                    Console.WriteLine("Krivi unos");
                    break;
            }

            Console.WriteLine("-------------");

            //7.	Za unešeni broj provjerite je li paran ili neparan
            Console.Write("Unesite broj: ");
            int broj = Convert.ToInt32(Console.ReadLine());

            //prvi način, spremamo rezultat dijeljenja sa brojem 2 u varijablu rezultatModula
            int rezultatModula = broj % 2;
            bool paranBroj = false;            
            
            //ako je rezultat dijeljenja jednak 0 to znači da je broj paran pa ažuriramo varijablu
            if (rezultatModula == 0)
            {
                paranBroj = true;
            }
            //ne trebamo pisati else jer je vrijednost varijable paranBroj inicijalno false

            //drugi način, u jednoj liniji provjeravamo ako je rezultat modula sa 2 jednak 0 što znači da je broj paran
            bool paranBroj2 = broj % 2 == 0;

            //ispis na prvi način
            if (paranBroj)
            {
                Console.WriteLine("Broj je paran");
            }
            else
            {
                Console.WriteLine("Broj je neparan");
            }

            //ispis pomoću ternarnog upita
            //uvjet koji može biti true ili false ? vrijednost koja se vraća ako je uvjet true : vrijednost koja se vraća ako je uvjet false
            Console.WriteLine("Broj je " + (paranBroj ? "paran" : "neparan"));

            Console.WriteLine("-------------");

            //8.	Napišite naredbu koja unešeni string ispiše u obrnutom redoslijedu
            Console.Write("Unesite riječ: ");
            string rijec = Console.ReadLine();

            //for petlja kreće od zadnjeg znaka u stringu i ide do prvog
            //krećemo od zadnjeg znaka koji je na indeksu: dužina stringa - 1 jer je prvi znak na indeksu 0 kao i kod polja,
            //npr ako je dužina riječi 8, max index je 7 jer se počinje od 0
            //i idemo sve do prvog znaka koji je na indeksu 0, indeks se umanjuje svakom iteracijom petlje
            for(int i = rijec.Length - 1; i >= 0; i--)
            {
                Console.Write(rijec[i]);
            }

            //koristimo Console.ReadKey() da se nam aplikacija ne zatvori automatski kad dođe do kraja
            Console.ReadKey();
        }
    }
}
