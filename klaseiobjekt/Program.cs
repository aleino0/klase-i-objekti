using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klaseiobjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciranje objekta
            Osoba osoba = new Osoba();

            osoba.SetIme("Pero");
            osoba.SetPrezime("Perić");
            osoba.SetGodRodjenja(2005);
            osoba.SetVisina(179);
            osoba.SetTezina(89);
            osoba.Setspol('M');

            //ispis podataka
            Console.WriteLine("Osoba 1");
            Console.WriteLine("ime i prezime: " +osoba.GetIme() + " " + osoba.GetPrezime() 
                + "\r\nGodina rođenja: " + osoba.GetgodRodjenja() 
                + "\r\nvisina: " + osoba.Getvisina() 
                + "\r\ntezina: " + osoba.Gettezina() 
                + "\r\nspol: " + osoba.Getspol());

            //instanca objekt 2
            Osoba osoba2 = new Osoba("Ana", "Anić", 2001, 160, 62, 'Ž');
            Console.WriteLine("\r\nOsoba2");
            Console.WriteLine(osoba2.ispis());

            Console.WriteLine("\r\nosoba2 - override");
            Console.WriteLine(osoba2.ToString());

            Console.ReadKey();
        }
    }

    class Osoba
    {
        //svojstva
        string ime, prezime;
        int godRodjenja, visina, tezina;
        char spol;

        //metode

        //set metode - služe za postavljeanje vrijednosti svojstva
        public void SetIme(string ime)
        {
            this.ime = ime;
        }
        public void SetPrezime(string prezime)
        {
            this.prezime = prezime;
        }
        public void SetGodRodjenja(int godRodjenja)
        {
            this.godRodjenja = godRodjenja;
        }
        public void SetVisina(int visina)
        {
            this.visina = visina;
        }
        public void SetTezina(int tezina)
        {
            this.tezina = tezina;
        }
        public void Setspol(char spol)
        {
            this.spol = spol;
        }

        //get metoda - služe za čitanje vrijednosti svojstva
        public string GetIme()
        {
            return this.ime;
        }
        public string GetPrezime()
        {
            return this.prezime;
        }
        public int GetgodRodjenja()
        {
            return this.godRodjenja;
        }
        public int Getvisina()
        {
            return this.visina;
        }
        public int Gettezina()
        {
            return this.tezina;
        }
        public char Getspol()
        {
            return this.spol;
        }
        //metode za ispis
        public string ispis()
        {
            string ispis=("ime i prezime: " + this.GetIme() + " " + this.GetPrezime()
               + "\r\nGodina rođenja: " + this.GetgodRodjenja()
               + "\r\nvisina: " + this.Getvisina()
               + "\r\ntezina: " + this.Gettezina()
               + "\r\nspol: " + this.Getspol());

            return ispis;
        }

        public override string ToString()
        {
            string ispis = ("ime i prezime: " + this.GetIme() + " " + this.GetPrezime()
               + "\r\nGodina rođenja: " + this.GetgodRodjenja()
               + "\r\nvisina: " + this.Getvisina()
               + "\r\ntezina: " + this.Gettezina()
               + "\r\nspol: " + this.Getspol());

            return ispis;
        }

            //konstruktori
            public Osoba()
        {

        }
        public Osoba(string ime, string prezime, int godRodjenja, int visina, int tezina, char spol)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.godRodjenja = godRodjenja;
            this.visina = visina;
            this.tezina = tezina;
            this.spol = spol;
        }

        public Osoba(int godRodjenja)
        {
            this.godRodjenja = godRodjenja;
        }
    }
}
