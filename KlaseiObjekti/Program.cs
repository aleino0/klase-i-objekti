using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlaseiObjekti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //objekti
            Zrakoplov tipaX380 = new Zrakoplov();
            Zrakoplov tipaC162 = new Zrakoplov();
            Zrakoplov tipaPC_21 = new Zrakoplov();

            tipaX380.SetNaziv("AirBus");
            tipaX380.SetSnagaMotora(2000);
            tipaX380.SetDosegLeta(6000);

            tipaC162.SetNaziv("Cessna Skycatcher");
            tipaC162.SetSnagaMotora(75);
            tipaC162.SetDosegLeta(870);

            tipaPC_21.SetNaziv("Pilatus");
            tipaPC_21.SetSnagaMotora(1200);
            tipaPC_21.SetDosegLeta(1333);
            //ispis
            Console.WriteLine("Zrakoplov tipa x380");
            Console.WriteLine("Naziv: " + tipaX380.GetNaziv()
                +"\r\nSnaga motora: "+ tipaX380.GetSnagaMotora()+ "kW"
                +"\r\nDoseg leta: "+ tipaX380.GetDosegLeta()+ "km");

            Console.WriteLine("\r\nZrakoplov tipa C162");
            Console.WriteLine("Naziv: " + tipaC162.GetNaziv()
                + "\r\nSnaga motora: " + tipaC162.GetSnagaMotora() + "kW"
                + "\r\nDoseg leta: " + tipaC162.GetDosegLeta() + "km");

             Console.WriteLine("\r\nZrakoplov tipa PC_21");
            Console.WriteLine("Naziv: " + tipaPC_21.GetNaziv()
                +"\r\nSnaga motora: "+ tipaPC_21.GetSnagaMotora()+ "kW"
                +"\r\nDoseg leta: "+tipaPC_21.GetDosegLeta()+ "km");


            Console.ReadKey();
        }
    }

    class Zrakoplov
    {
        //deklaracija varijabli
        string naziv;
        int snagaMotora;
        double dosegLeta;


        //metode
        //set metode
        public void SetNaziv(string naziv)
        {
            this.naziv= naziv;
        }
        public void SetSnagaMotora(int snagaMotora)
        {
            this.snagaMotora= snagaMotora;
        }
        public void SetDosegLeta(double dosegLeta)
        {
            this.dosegLeta= dosegLeta;
        }

        //get metode
        public string GetNaziv()
        {
            return this.naziv;
        }
        public int GetSnagaMotora()
        { 
            return this.snagaMotora;
        }
        public double GetDosegLeta()
        {
            return this.dosegLeta;
        }

        //konstruktor
        public Zrakoplov()
        {

        }
        public Zrakoplov(string naziv, int snagaMotora, double dosegLeta)
        {
            this.naziv = naziv;
            this.snagaMotora = snagaMotora;
            this.dosegLeta = dosegLeta;
        }
    }
}

