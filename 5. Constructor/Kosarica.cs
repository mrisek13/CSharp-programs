using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Vj6
{
    class Kosarica
    {
                // privatne varijable
        // A GUID (globally unique identifier) is a 128-bit text string that represents an identification (ID)
        // primjer: 3280531c-0a8a-4f5f-8974-5a9fa52ba412
        Guid id;
        VlasnikKosarice kupac;
        StatusKosarice status;
        //Lista je slična polju, tj. omogućava spremanje kolekcije određenog tipa podataka
        List<StavkaKosarice> stavke = new List<StavkaKosarice>();

        // 1.	Defaultni konstruktor
        public Kosarica()
        {
            // 3.	U konstruktorima definirati vrijednost varijable id koristeći Guid.NewGuid()
            // Guid.NewGuid() nam vraća jedinstveni identifikator
            id = Guid.NewGuid();
        }

        // 2.	Kostruktor sa parametrom VlasnikKosarice
        public Kosarica(VlasnikKosarice kupac)
        {
            id = Guid.NewGuid();
            this.kupac = kupac;
        }

        // 4.	Svojstvo (read-only) Id
        public string Id
        {
            // Svojstvo je read-only jer samo vraća vrijednost a ne može je definirati jer fali set pristupnik
            get { return id.ToString(); }
        }

        // 5.	Svojstvo Kupac
        public VlasnikKosarice Kupac
        {
            get { return kupac; }
            set { kupac = value; }
        }

        // 6.	Svojstvo (read-only) StavkeKosarice
        public List<StavkaKosarice> Stavke
        {
            get { return stavke; }
        }

        // 7.	Svojstvo Vrijednost – vraća zbroj vrijednosti svih stavaka košarice
        public decimal Vrijednost
        {
            get
            {
                decimal vrijednost = 0;

                foreach(StavkaKosarice stavka in stavke)
                {
                    vrijednost += stavka.Vrijednost;
                }

                // ILI
                /*
                for (int i = 0; i < stavke.Count; i++)
                {
                    vrijednost += stavke[i].VratiVrijednost();
                }
                */

                return vrijednost;
            }
        }

        // 8.	Privatno svojstvo Zakljucana - vraća ako je košarica zaključana.
        // Zaključena je ako joj je status Plaćena ili Stornirana.
        // Ako je košarica zaključana onda nije moguće dodavanje i brisanje stavaka iz košarice metodama u nastavku
        public bool Zakljucana
        {
            get
            {
                if (status == StatusKosarice.Placena
                    || status == StatusKosarice.Stornirana)
                    return true;
                else
                    return false;
            }
        }

        // 9.	Metoda DodajStavku(StavkaKosarice)
        public void DodajStavku(StavkaKosarice st)
        {
            //Stavka se može dodati samo ako košarica nije zaključana (znači da je u stanju Aktivna ili Prazna)
            if (Zakljucana == false)
                //objekt se dodaje u listu naredbom Add
                stavke.Add(st);
        }

        // 10.	Metoda DodajStavku(opis, kolicina, cijena)
        public void DodajStavku(string opis, float kolicina, decimal cijena)
        {
            //Stavka se može dodati samo ako košarica nije zaključana (znači da je u stanju Aktivna ili Prazna)
            if (Zakljucana == false)
            {
                // Kreiramo instancu razreda StavkaKosarice na temelju dobivenih parametara i dodajemo u listu
                StavkaKosarice st = new StavkaKosarice(opis, kolicina, cijena);
                stavke.Add(st);
            }
        }

        // 11.	BrisiStavku(indeks stavke)
        public void BrisiStavku(int indeks) {
            if (Zakljucana == false)
                // RemoveAt metoda briše iz liste element na određenom indeksu
                stavke.RemoveAt(indeks);
        }

        // 12.	BrisiStavku(StavkaKosarice)
        public void BrisiStavku(StavkaKosarice st) {
            if (Zakljucana == false)
                // Remove metoda briše iz liste određeni objekt
                stavke.Remove(st);
        }

        // 13.	IsprazniKosaricu() – briše sve stavke
        public void IsprazniKosaricu() {
            if (Zakljucana == false)
                // Clear metoda briše sve elemente, objekte iz liste
                stavke.Clear();
        }

        // 14.	Metoda Plati() – mijenja status u plaćeno
        public void Plati()
        {
            status = StatusKosarice.Placena;
        }

        // 15.	Metoda Storniraj() – mijenja status u stornirano
        public void Storniraj()
        {
            status = StatusKosarice.Stornirana;
        }

        // 16.	Svojstvo koje vraća status košarice
        public StatusKosarice Status
        {
            get { return status; }
        }
    }
}
